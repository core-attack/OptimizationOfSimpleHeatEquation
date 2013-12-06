using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace OptimizationOfSimpleHeatEquation
{
    class TaskSolution
    {
        public TaskSolution(int N, double gamma, double lambda, double tau, string ro0, string ro1, string phi) 
        {
            setParaments(N, gamma, lambda, tau, ro0, ro1, phi);
        }

        double Jmin = 0;
        string error = "";
        int N = 0;
        double gamma = 0;
        double lambda = 0;
        double tau = 0;
        string ro0 = "";
        string ro1 = "";
        string phi = "";

        Parser p = new Parser();

        void setParaments(int N, double gamma, double lambda, double tau, string ro0, string ro1, string phi)
        {
            this.N = N;
            this.gamma = gamma;
            this.lambda = lambda;
            if (this.lambda < 0 || this.lambda > 1)
                error += "lambda = " + this.lambda.ToString();
            this.tau = tau;
            this.ro0 = ro0;
            this.ro1 = ro1;
            this.phi = phi;
            RESULTS = "";
            println(String.Format("{0} = {1}, {2} = {3}, {4} = {5}, {6} = {7}, {8} = {9}, {10} = {11}, {12} = {13}", "N", N, "gamma", gamma, "lambda", lambda, "tau", tau, "ro0", ro0, "ro1", ro1, "phi", phi));
        }

        public void getShortSolution()
        {
            int n = N - 1;
            println(String.Format("{0} = {1}", "n", n));
            
            double h = 1.0 / (2 * N); // стр. 1
            println(String.Format("{0} = {1}", "h", h));
            
            double teta = gamma * gamma * tau / (h * h); // стр. 157
            println(String.Format("{0} = {1}", "teta", teta) + "//стр. 157\n");
            
            double v = h / (3 * tau); // стр. 157
            println(String.Format("{0} = {1}", "v", v) + "//стр. 157\n");
            
            double[] hj = new double[2 * N + 1];
            for (int j = 0; j <= 2 * N; j++)
                hj[j] = j * h;
            println(hj, "hj");
            
            double[] taui = new double[3];
            for (int i = 0; i <= 2; i++)
                taui[i] = i * tau;
            println(taui, "taui");
            
            double mu = 1 - lambda;//стр. 155
            println(String.Format("{0} = {1}", "mu", mu));
            
            double lm = lambda * mu;

            double omega = lambda - mu; // в пределах [-1, 1] стр. 155
            if (omega < -1 || omega > 1)
                error += "omega = " + omega.ToString() + "\n";
            println(String.Format("{0} = {1}", "omega", omega));

            double x = (4 - 9 * lm + 3 * lm * lm) / (lm * (1 - 3 * lm)); //стр. 165
            double tmp = 15 + 8 * Math.Sqrt(3);
            if (x <= tmp)
                error += "x <= 15 + 8 * Math.Sqrt(3)\n";
            println(String.Format("{0} = {1}", "x", x) + "//стр. 165");
            println("Ограничение на х: x >= 15 + 8 * Math.Sqrt(3) = " + tmp);

            double R = (7.0 / 8.0) + 4 * teta + 6 * teta * teta + ((1.0 / 8.0) + 2 * teta * teta) * omega * omega; //стр. 160
            if (R < 0)
                error += "R < 0\n";
            println(String.Format("{0} = {1}", "R", R) + "//стр. 160");

            double r = 1 + 3 * teta; // стр. 160
            println(String.Format("{0} = {1}", "r", r));

            double P = 2 * r * teta * omega; //стр. 165
            println(String.Format("{0} = {1}", "P", P) + "//стр. 165");

            double Q = 3 * R - 2 * r * r; //стр. 165
            tmp = 5 / 8 + (3 / 8 + 6 * teta * teta) * omega * omega;
            println(String.Format("{0} = {1}", "Q", Q) + "//стр. 165");
            println("Ограничение на Q: Q = 5 / 8 + (3 / 8 + 6 * teta * teta) * omega * omega > 0, Q = " + tmp + "//стр. 165");

            double S = R - 2 * teta * teta * omega * omega; //стр. 165
            println(String.Format("{0} = {1}", "S", S) + "//стр. 165");

            double y = (Q + S) / (Q - S); //стр. 165
            println(String.Format("{0} = {1}", "y", y) + "//стр. 165");

            double[,] u = new double[3, 2 * N + 1]; // стр. 155
            for (int j = 0; j <= 2 * N; j++)
                u[0, j] = p.Evaluate(phi, hj[j]);
            u[1, 0] = p.Evaluate(ro0, taui[1]);
            u[2, 0] = p.Evaluate(ro0, taui[2]);
            u[1, 2 * N] = p.Evaluate(ro1, taui[1]);
            u[2, 2 * N] = p.Evaluate(ro1, taui[2]);

            println(u, "u");

            double[] Ux = setU(x, 2 * N);
            println("//стр. 164");
            println(Ux, "Ux");

            double[] Uy = setU(y, 2 * N);
            println("//стр. 164");
            println(Uy, "Uy");

            double[] Tx = setT(x, 2 * N, Ux);
            println("//стр. 164-165");
            println(Tx, "Tx");

            double[] Ty = setT(y, 2 * N, Uy);
            println("//стр. 164-165");
            println(Ty, "Ty");

            //в pdf199 это большие Z с индексом k
            double[] Zk = new double[N + 1]; //стр. 170
            for (int k = 1; k <= N; k++)
                Zk[k] = p.Evaluate(phi, hj[2 * k - 2]) - 2 * p.Evaluate(phi, hj[2 * k - 1]) + p.Evaluate(phi, hj[2 * k]);
            println(Zk, "Zk");

            double[,] B = new double[n + 1, n + 1];// стр. 164
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                    if (i <= j)
                        B[i, j] = Math.Pow(-1, i + j) * Uy[i - 1] * Ux[n - j];
                    else
                        B[i, j] = Math.Pow(-1, i + j) * Uy[j - 1] * Ux[n - i];

            println(B, "B");

            double Sum = 0;
            //в pdf199 это маленькие x, y с индексом j на стр. 155
            //вычислять будем только крайние элементы массива
            double[] X = new double[2 * N + 1];
            double[] Y = new double[2 * N + 1];

            X[0] = p.Evaluate(ro0, 2 * tau) - p.Evaluate(ro0, 0);//стр. 170
            X[2 * N] = p.Evaluate(ro1, 2 * tau) - p.Evaluate(ro1, 0);
            println("X[0] = " + X[0]);
            println("X[2 * N] = " + X[2 * N]);

            double first = Uy[n] * (X[0] * X[0] - X[2 * N] * X[2 * N]);  //стр. 170 
            println("first = " + first);
            Sum = 0;
            for (int k = 1; k <= N; k++)
                if (n - k == -1)
                    Sum += Math.Pow(-1, k) * Uy[N - k] * Zk[k]; // Uy[-1] = 0 по определению
                else
                    Sum += Math.Pow(-1, k) * (Uy[N - k] + Uy[n - k]) * Zk[k];
            println("Sum = " + Sum);
            first += 4 * teta * X[0] * Sum;
            println("first = " + first);
            Sum = 0;
            for (int k = 1; k <= N; k++)
                if (k - 2 == -1)
                    Sum += Math.Pow(-1, N - k) * Uy[k - 1] * Zk[k];
                else
                    Sum += Math.Pow(-1, N - k) * (Uy[k - 1] + Uy[k - 2]) * Zk[k];
            println("Sum = " + Sum);
            first += 4 * teta * X[2 * N] * Sum;
            println("first = " + first);
            first *= 12 * P / (R * Uy[n]);
            println("first = " + first);
            double second = 1 / (1 + y);
            println("second = " + second);
            second *= Ty[N] * X[0] * X[0] + 2 * Math.Pow(-1, n) * X[0] * X[2 * N] + Ty[N] * X[2 * N] * X[2 * N];
            println("second = " + second);
            Sum = 0;
            for (int k = 1; k <= N; k++)
                Sum += Zk[k] * Zk[k];
            println("Sum = " + Sum);
            second += 8 * teta * teta * Uy[n] * Sum;
            println("second = " + second);
            Sum = 0;
            for (int k = 1; k <= N; k++)
                if (n - k == -1)
                    Sum += Math.Pow(-1, k) * Uy[N - k] * Zk[k]; // Ux[-1] = 0
                else
                    Sum += Math.Pow(-1, k) * (Uy[N - k] - Uy[n - k]) * Zk[k];
            println("Sum = " + Sum);
            second += 4 * teta * X[0] * Sum;
            println("second = " + second);
            Sum = 0;
            for (int k = 1; k <= N; k++)
                if (k - 2 == -1)
                    Sum += Math.Pow(-1, n - k) * Uy[k - 1] * Zk[k]; // Ux[-1] = 0
                else
                    Sum += Math.Pow(-1, n - k) * (Uy[k - 1] - Uy[k - 2]) * Zk[k];
            println("Sum = " + Sum);
            second += 4 * teta * X[2 * N] * Sum;
            println("second = " + second);
            Sum = 0;
            double pq = P / Q;
            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                    Sum += B[i, j] * ((1 - pq) * Zk[i] + (1 + pq) * Zk[i + 1]) * ((1 - pq) * Zk[j] + (1 + pq) * Zk[j + 1]);
            println("Sum = " + Sum);
            second -= 4 * teta * teta * (1 + y) * Sum;
            println("second = " + second);
            second *= 12 * Q / (R * Uy[n]);
            println("second = " + second);
            double sigmaX = first + second;  //стр. 170

            println(String.Format("{0} = {1}", "sigmaX", sigmaX) + "//стр. 170");

            double sigmaY = 0;  //стр. 167
            Y[0] = p.Evaluate(ro0, 2 * tau) - 2 * p.Evaluate(ro0, tau) + p.Evaluate(ro0, 0);
            Y[2 * N] = p.Evaluate(ro1, 2 * tau) - 2 * p.Evaluate(ro1, tau) + p.Evaluate(ro1, 0);
            println("Y[0] = " + Y[0]);
            println("Y[2 * N] = " + Y[2 * N]);
            if (lm != 0)
            {
                sigmaY = 6 * (4 - 9 * lm + 3 * lm * lm) / (1 - lm);
                println("sigmaY = " + sigmaY);
                sigmaY *= 1 / (x * Ux[n]);
                println("sigmaY = " + sigmaY);
                sigmaY *= Tx[N] * Y[0] * Y[0] + 2 * Math.Pow(-1, n) * Y[0] * Y[2 * N] + Tx[N] * Y[2 * N] * Y[2 * N];
                println("sigmaY = " + sigmaY);
            }
            else
            {
                sigmaY = 24 * (Y[0] * Y[0] + Y[2 * N] * Y[2 * N]);
                println("sigmaY = " + sigmaY);
            }
            println(String.Format("{0} = {1}", "sigmaY", sigmaY) + "//стр. 167");
            
            println("v / 24 = " + (v / 24));

            Jmin = (v / 24) * (sigmaX + sigmaY);

            println(String.Format("{0} = {1}", "Jmin", Jmin));
        }

        double[] setU(double x, int length) //стр. 164
        {
            double[] U = new double[length];
            for (int i = -2; i < length - 2; i++)
            {
                if (i == -2)
                    U[0] = 1;
                else if (i == -1)
                    U[1] = 2 * x;
                else
                    U[i + 2] = ((2 * x * U[i + 1] - U[i]));
            }
            return U;
        }

        double[] setT(double x, int length, double[] U) //стр. 164-165
        {
            double[] T = new double[length + 1];
            T[0] = 0;
            for (int i = 0; i < length; i++)
                if (i - 1 == -1)
                    T[i + 1] = x * U[i];
                else
                    T[i + 1] = x * U[i] - U[i - 1];
            return T;
        }

        string RESULTS = "";
        void print(string s)
        {
            RESULTS += s;
        }

        void println(string s)
        {
            RESULTS += s + "\n";
        }

        void println(double[] d, string name)
        {
            RESULTS += name + "\n";
            for (int i = 0; i < d.Length; i++ )
                RESULTS += String.Format("{0}[{1}] = {2}", name, i, d[i]) + "\n";
        }

        void println(double[,] d, string name)
        {
            RESULTS += name + "\n";
            for (int i = 0; i < d.GetLength(0); i++)
            {
                for (int j = 0; j < d.GetLength(1); j++)
                    RESULTS += String.Format("{0}[{1},{2}] = {3}", name, i, j, d[i, j]) + " ";
                RESULTS += "\n";
            }
        }

        public string printArrays()
        {
            return RESULTS;
        }

        public void Save(string path)
        {
            println("___________" +
                    DateTime.Now.ToShortTimeString().Replace(':', '-') + " " + DateTime.Today.ToShortDateString().Replace('.', '_') +
                    "___________");
            println("Ошибки: " + getErrors());
            File.WriteAllLines(path, RESULTS.Split('\n'), Encoding.UTF8);
        }

        public string getErrors()
        {
            return error;
        }

        public string getJmin()
        {
            return String.Format("{0:0.0000000000000000000}", Jmin);
        }
    }
}
