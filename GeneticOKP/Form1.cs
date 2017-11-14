using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneticOKP
{
    public partial class Form1 : Form
    {
        int[] count_of_Z_1 = new int[] { /*14, 15, 16,*/ 17, 18, 19, 20, 21, 22 , 24 ,25, 26 , 28 , 30 , 32 , 34,
                                        38, 40, 42, 45, 48, 50, 60, 63, 67, 70, 71, 75, 80, 85, 90, 95, 100,
                                        106, 112, 118, 125, 132, 140, 150,/* 160, 170, 180, 190, 200 */};
        int[] count_of_Z_ = new int[] { 8, 9, 10, 11, 12, 13 , 23 , 27, 29 , 31, 33 , 35, 37 , 39 ,
                                        41, 43 , 44 , 46 , 49, 51, 52, 54, 55, 58, 59, 61, 62, 64,
                                        65,66, 68, 69, 72-74, 78, 81-84, 87, 88, 92, 96, 98,
                                        102, 103, 104, 105, 108, 109, 110, 114, 115, 116, 117, 120,
                                        122, 126, 128, 130, 135, 144, 145, 155, 156, 165, 168, 175,
                                        176, 185, 189, 192, 195, 198 };
        int[] count_of_Z_1_ = new int[] {14, 15, 16, 17, 18, 19, 20, 21, 22 , 24 ,25, 26 , 28 , 30 , 32 , 34,
                                        38, 40, 42, 45, 48, 50, 60, 63, 67, 70, 71, 75, 80, 85, 90, 95, 100,
                                        106, 112, 118, 125, 132, 140, 150, 160, 170, 180, 190, 200,
                                    8, 9, 10, 11, 12, 13 , 23 , 27, 29 , 31, 33 , 35, 37 , 39 ,
                                        41, 43 , 44 , 46 , 49, 51, 52, 54, 55, 58, 59, 61, 62, 64,
                                        65,66, 68, 69, 72, 73, 74, 78, 81, 82, 83, 84, 87, 88, 92, 96, 98,
                                        102, 103, 104, 105, 108, 109, 110, 114, 115, 116, 117, 120,
                                        122, 126, 128, 130, 135, 144, 145, 155, 156, 165, 168, 175,
                                        176, 185, 189, 192, 195, 198 };


        List<int[]> Pool = new List<int[]>();
        int[] GoodRes;
        float max_Gear;

        int len_individ;
        bool Solve = false;
        int step = 0;

        int Pers = 50;

        int Permutation_person_count = 25;
        int Permutation_count = 25;

        int Mutation_count = 25;
        int Mutation_persone_count = 25;

        Random rnd = new Random();

        float i;
        int steps_red;

        
        public Form1()
        {
            InitializeComponent();


            i = (float)Convert.ToDouble(tb_i_n.Text);
            steps_red = Convert.ToInt32(tb_Step.Text);

            len_individ = steps_red * 2;


            for (int i = 0; i < Pers*2; i++)
            {
                int[] item = new int[len_individ];
                for (int j = 0; j < len_individ; j++)
                {
                    int ind = rnd.Next(count_of_Z_1.Length);
                    item[j] = count_of_Z_1[ind];
                }
                Pool.Add(item);

            }
        }

        void Generate()
        {
            for (int i = 0; i < Pers; i++)
            {
                int[] item = new int[len_individ];
                for (int j = 0; j < len_individ; j++)
                {
                    int ind = rnd.Next(count_of_Z_1.Length);
                    item[j] = count_of_Z_1[ind];
                }
                Pool.Add(item);

            }
        }

        void Clear()
        {
            Pool.Sort(delegate (int[] x, int[] y)
            {
                float x_rat = RatingElement(x);
                float y_rat = RatingElement(y);

                return x_rat.CompareTo(y_rat);
            });

            Pool.RemoveRange(Pers, Pool.Count - Pers);


        }

        private void Permutation()
        {
            for (int i = 0; i < Permutation_person_count; i++)
            {
                //int[] item = new int[len_individ];// = Pool[rnd.Next(Pool.Count)];
                int[] item = Pool[rnd.Next(Pool.Count)];

                //Pool[rnd.Next(Pool.Count)].CopyTo(item, 0);
                for (int j = 0; j < Permutation_count; j++)
                {
                    int start_index = rnd.Next(0, len_individ);
                    int end_index = rnd.Next(0, len_individ);

                    int buff = item[start_index];
                    item[start_index] = item[end_index];
                    item[end_index] = buff;
                }
                //Pool.Add(item);
            }
        }
        private void Mutation()
        {
            for (int i = 0; i < Mutation_persone_count; i++)
            {
                int Mutation_person = rnd.Next(0, Pool.Count);

                //int[] item = new int[len_individ];
                //Pool[rnd.Next(Pool.Count)].CopyTo(item, 0);

                for (int j = 0; j < Mutation_count; j++)
                {
                    
                    int Mutation_index = rnd.Next(0, len_individ);

                    int ind = rnd.Next(count_of_Z_1.Length);
                    int Mutation = count_of_Z_1[ind];

                    //item[Mutation_index] = Mutation;
                    Pool[Mutation_person][Mutation_index] = Mutation;
                }

                //Pool.Add(item);
            }
        }

        float getMaxGearD(int[] el)
        {
            float maxD = -1;

            //Пом максимальной шестерне
            //for (int i = 0; i < len_individ; i++)
            //    if (maxD < (0.4f * el[i])) maxD = 0.4f * el[i];


            //По сумме рахмеров
            float sum = el.Sum();


            maxD = sum;
            

            return maxD;
        }


        void SaveGood()
        {

            if ((GoodRes == null) || (RatingElement(GoodRes) > RatingElement(Pool[0])))
            {
                //if ( (GoodRes != null) && ( getMaxGearD(GoodRes) > getMaxGearD(Pool[0]) ) )
                //{
                    GoodRes = new int[len_individ];
                    Pool[0].CopyTo(GoodRes, 0);

                    float Rat = RatingElement(GoodRes);

                    if (Rat == 0)
                    {
                        Solve = true;
                        AppendText("\n\nSOLVE!!!  ", Color.Green);
                        WriteGoodRes();
                    }
                    step++;
                //}
            } else if (RatingElement(GoodRes) == RatingElement(Pool[0]))
            {
                if (getMaxGearD(GoodRes) > getMaxGearD(Pool[0]))
                {
                    GoodRes = new int[len_individ];
                    Pool[0].CopyTo(GoodRes, 0);
                    AppendText("\n\nNEW SOLVE!!! ", Color.Green);
                    WriteGoodRes();
                }
            }

        }

        float RatingElement(int[] el)
        {
            //float rat = 1;

            float[] i_nn = new float[steps_red];

            for (int i = 0; i < steps_red; i++)
                i_nn[i] = (float)el[2 * (i) + 1] / (float)el[2 * i];


            /*float i12 = (float)el[1] / (float)el[0];
            float i34 = (float)el[3] / (float)el[2];
            float i56 = (float)el[5] / (float)el[4];*/

            //rat = i12 * i34 * i56;
            float rat = i_nn.Aggregate((p, x) => p *= x);

            return Math.Abs(i - rat);

        }
        float RatingElement_i(int[] el)
        {
            float[] i_nn = new float[steps_red];

            for (int i = 0; i < steps_red; i++)
                i_nn[i] = (float)el[2 * (i) + 1] / (float)el[2 * i];
            float rat = i_nn.Aggregate((p, x) => p *= x);


            return rat;

        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if ((i != (float)Convert.ToDouble(tb_i_n.Text)) || (steps_red != Convert.ToInt32(tb_Step.Text)))
            {
                Pool.Clear();
                GoodRes = null;
                max_Gear = -1;
            }
            i = (float)Convert.ToDouble(tb_i_n.Text);
            steps_red = Convert.ToInt32(tb_Step.Text);
            len_individ = steps_red * 2;

            int iter = Convert.ToInt32(tb_iter_count.Text);

            for (int i = 0; i < iter; i++)
            {
                StepFunc();
            }
            AppendText("Current result: " + RatingElement_i(GoodRes).ToString() + "        Error: " + (100*(RatingElement_i(GoodRes) - i)/i).ToString() + "% \n");
        }

        void StepFunc()
        {
            Generate();

            //WriteToLogDef();

            Mutation();
            Permutation();

            Clear();

            //WriteToLogDef();

            SaveGood();

            //WriteToLogDef();
            
            //AppendText("Current num: " + Pool.Count.ToString() + "\n");

            //chart1.Series[0].Points.AddY(RatingElement(GoodRes));
            //chart1.Invalidate();
        }


        public void AppendText(string text, Color? color = null)
        {
            rtb_Log.SelectionStart =rtb_Log.TextLength;
            rtb_Log.SelectionLength = 0;
            rtb_Log.SelectionColor = color ?? Color.Black;
            rtb_Log.AppendText(text);
            rtb_Log.SelectionColor = rtb_Log.ForeColor;

            rtb_Log.Refresh();
            rtb_Log.Invalidate();
        }


        void WriteToLogDef()
        {
            int ii = 0;
            foreach (var item in Pool)
            {
                AppendText("[" + ii.ToString() + "] : ", Color.Black);
                AppendText("[" + RatingElement_i(item) + "] : ", Color.Black);
                for (int i = 0; i < len_individ; i++)
                {
                    AppendText(item[i].ToString()+ " ", Color.Black);
                }
                AppendText("\n", Color.Black);

                

                ii++;
            }
            AppendText("------------------------\n\n", Color.Black);
        }

        void WriteGoodRes()
        {
            AppendText("Good : \n", Color.Green);
            AppendText("[" + RatingElement_i(GoodRes) + "] : \n", Color.Black);
            for (int i = 0; i < len_individ; i+=2)
            {
                AppendText(GoodRes[i].ToString() + " - " + GoodRes[i+1].ToString() + " i = " + ((float)GoodRes[i+1]/(float)GoodRes[i]).ToString() + "\n", Color.Black);
            }
            AppendText("\n", Color.Black);

        }

        private void btn_ShowPool_Click(object sender, EventArgs e)
        {
            WriteToLogDef();
        }

        private void btn_Show_good_Click(object sender, EventArgs e)
        {
            WriteGoodRes();
        }
    }
}					