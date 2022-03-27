using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sort
{
    public partial class Form1 : Form
    {
        Gomb[] g;
        
        int left;
        int j = 0; // step by step sort variable
        int tovabb = 0;
        int min_key; // selection sort variable
        int Set_Sort = 0;
        Gomb item;
        int i = 5;  // hsort
        int r = 0;//buble_sort;
        Gomb t; // hsort
        List<Color> szinek = new List<Color> { Color.Red, Color.OrangeRed, Color.Orange, Color.Yellow, Color.YellowGreen, Color.Green, Color.DarkGreen, Color.DarkBlue, Color.Blue, Color.Aqua };
        public Form1()
        {
            InitializeComponent();
            about_panel.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            Next_Button.Visible = false;
            simpsort_text.Visible = false;
            effsort_text.Visible = false;
            bubsort_text.Visible = false;
            choose_text.Visible = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            g = new Gomb[10];
            for (int i = 0; i < g.Count(); i++)
            {
                g[i] = new Gomb();
                g[i].Parent = panel1;
                g[i].Width = 80;
                g[i].Height = 80;
                g[i].Left = i * 80;
                g[i].Top = 25;
                g[i].sorszam = i;
                g[i].sorszam2 = i;
                g[i].BackColor = szinek[i];
                g[i].Text = (i+1).ToString();
                ControlExtension.Draggable(g[i], true);
                g[i].MouseDown += new System.Windows.Forms.MouseEventHandler(this.g_MouseDown);
                g[i].MouseUp += new System.Windows.Forms.MouseEventHandler(this.g_MouseUp);
            }
            Button info = new Button();
            info.Parent = panel1;
            info.Width = 40;
            info.Height = 40;
            info.Left = 10;
            info.Top = 320;
            info.BackColor = Color.Black;
            info.Click += new System.EventHandler(this.info_Click);
        }
        private void info_Click(object sender,EventArgs e)
        {
            
        }
        private void g_MouseDown(object sender, MouseEventArgs e)
        {
            Gomb temp = (Gomb)sender;
            temp.BringToFront();
            left = temp.Left;
            j = 0;

        }
        private void g_MouseUp(object sender, MouseEventArgs e)
        {
            Gomb temp = (Gomb)sender;
            int t = temp.Left / 80;
            g[t].sorszam = left / 80;
            temp.sorszam = t;
            change(t, left / 80);

        }
        private void change(int p_first, int p_second)
        {
            Gomb l_tmp = g[p_first];    //Gombcsere
            g[p_first] = g[p_second];
            g[p_second] = l_tmp;
            g[p_first].Left = g[p_first].sorszam * 80;
            g[p_second].Left = g[p_second].sorszam * 80;
            g[p_first].Top = 25;
            g[p_second].Top = 25;
        }
        private void rendez_sor() //sorszam szerinti ujrarajzolas
        {
            for (int i = 0; i < 10; i++)
            {
                
                g[i].Top = 25;

            }
        }
        // SIMP SORT
        private void Simple_sort_step()
        {
            
         
            Gomb tmp;
            if (tovabb==0)
            {
                g[j].Top = 40;
                
            }
            if (tovabb == 1)
            {
                min_key = j;
                for (int k = j + 1; k < 10; k++)
                {
                    if (Convert.ToInt32(g[k].Text) < Convert.ToInt32(g[min_key].Text))
                    {
                        min_key = k;
                    }
                }
                g[min_key].Top = 40;
            }
            if (tovabb == 2)
            {
                tmp = g[min_key];
                g[min_key] = g[j];
                g[j] = tmp;
                g[min_key].Left = min_key * 80;
                g[min_key].Top = 25;
                g[j].Left = j * 80;
                g[j].Top = 25;
            }
        }
        // INSTANT SORT
        private void Simple_sort()
        {
            int min_key;
            Gomb tmp;
            for (int j = 0; j < 10; j++)
            {
                min_key = j;

                for (int k = j + 1; k < 10; k++)
                {
                    if (Convert.ToInt32(g[k].Text) < Convert.ToInt32(g[min_key].Text))
                    {
                        min_key = k;
                    }
                }

                tmp = g[min_key];
                g[min_key] = g[j];
                g[j] = tmp;
                g[min_key].Left = min_key * 80;
                g[j].Left = j * 80;
            }
        }
        // INSERTION SORT
        private void insertsort()
        {
            if (tovabb == 0)
            {
                item = g[j];
                g[j].Top = 40; 
            }
            if (tovabb == 1)
            {
                int ins = 0;
                for (int ints = j - 1; ints >= 0 && ins != 1;)
                {
                    if (Convert.ToInt32(item.Text) < Convert.ToInt32(g[ints].Text))
                    {
                        g[ints + 1] = g[ints];
                        g[ints + 1].Left = (ints + 1) * 80;
                        ints--;
                        g[ints + 1] = item;
                        g[ints + 1].Left = (ints + 1) * 80;
                    }
                    else ins = 1;
                }
                
            }
            if (tovabb == 2)
            {
                rendez_sor();
            }
        }
        // HEAP SORT
        private void hsort()
        {
            
            if (tovabb == 0)
            {
                adjust(i, 9);
            }
            if (tovabb == 1)
            { 
                t = g[i + 1];
                g[i + 1] = g[0];
                g[i + 1].Left = (i + 1) * 80;
                g[0] = t;
                g[0].Left = Convert.ToInt32(t.Text) * 80;
                adjust(0, i);
            }
        }
        private void adjust(int i, int n)
        {
            int j;
            Gomb t;
            try
            {
                t = g[i];
                j = 2 * i;
                while (j <= n)
                {
                    if (j < n && Convert.ToInt32(g[j].Text) < Convert.ToInt32(g[j + 1].Text))
                        j++;
                    if (Convert.ToInt32(t.Text) >= Convert.ToInt32(g[j].Text))
                        break;
                    g[j / 2] = g[j];
                    g[j / 2].Left = j / 2 * 80;
                    j *= 2;
                }
                g[j / 2] = t;
                g[j / 2].Left = j / 2 * 80;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Array Out of Bounds ", e);
            }
        }
        //MERGE SORT
        private void DoMerge(int left, int mid, int right)
        {
            Gomb[] tp = new Gomb[25];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (Convert.ToInt32(g[left].Text) <= Convert.ToInt32(g[mid].Text))
                    tp[tmp_pos++] = g[left++];
                else
                    tp[tmp_pos++] = g[mid++];
            }

            while (left <= left_end)
                tp[tmp_pos++] = g[left++];

            while (mid <= right)
                tp[tmp_pos++] = g[mid++];

            for (i = 0; i < num_elements; i++)
            {
                g[right] = tp[right];
                g[right].Left = (Convert.ToInt32(tp[right].Text) - 1) * 80;
                right--;
            }
        }

        private void mergesort(int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                mergesort(left, mid);
                mergesort((mid + 1), right);

                DoMerge(left, (mid + 1), right);
            }
        }
        //Bubble Sort
        private void bubble_sort()
        {
            Gomb t = new Gomb();
            bool csere = false;
            if (j==0)
            { 
                g[r].Top = 40; 
            }
            if (j == 1)
            {
                for (int p = 0; p <= 8; p++)
                {
                    g[r + 1].Top = 40;
                    if (Convert.ToInt32(g[r].Text) > Convert.ToInt32(g[r + 1].Text))
                    {
                        t = g[r];
                        g[r] = g[r + 1];
                        g[r + 1] = t;
                        g[r].Left = r * 80;
                        g[r + 1].Left = (r + 1) * 80;
                        csere = true;
                    }

                }
                g[9].Top = 25;
            }
            if(j==2)
            {
                g[r].Top = 25;
                if (csere)
                {
                    g[r+1].Top = 25;
                    csere = false;
                }
            }
        }
        private void ShellSort()
        {

            int gap = 5;
            Gomb temp;

            while (gap > 0)
            {
                for (int i = 0; i + gap < 10; i++)
                {
                    int j = i + gap;
                    temp = g[j];

                    while (j - gap >= 0 && Convert.ToInt32(temp.Text) < Convert.ToInt32(g[j - gap].Text))
                    {
                        g[j] = g[j - gap];
                        g[j].Left = g[j-gap].Left;
                        j -= gap;
                    }

                    g[j] = temp;
                    g[j].Left = (Convert.ToInt32(temp.Text)-1) * 80;
                }

                gap /=  2;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!stepbystep.Checked)
            {
                if (Set_Sort == 1)
                {
                    if (j == 10)
                    {
                        j = 0;
                    }
                    Simple_sort_step();
                    if (tovabb == 0)
                    {
                        tovabb = 1;
                    }
                    else if (tovabb == 1)
                    {
                        tovabb = 2;
                    }
                    else if (tovabb == 2)
                    {
                        tovabb = 0;
                        j++;
                    }
                }
                else if (Set_Sort == 2)
                {
                    if (j == 10)
                    {
                        j = 1;
                    }
                    insertsort();
                    if (tovabb == 0)
                    {
                        tovabb++;
                    }
                    else if (tovabb == 1)
                    {
                        tovabb++;
                    }
                    else if (tovabb == 2)
                    {
                        tovabb = 0;
                        j++;
                    }
                }
                else if(Set_Sort == 3)
                {
                    
                    hsort();
                    
                    if (i == 0 && tovabb == 0)
                    {
                        tovabb = 1;
                        i = 9;
                    }else if (i == 0 && tovabb ==1)
                    {
                        i = 6;
                        tovabb = 0;
                    }
                    i--;

                }
                else if(Set_Sort == 4)
                {
                    mergesort(0,9);
                }
                else if(Set_Sort == 5)
                {
                    if(r == 9)
                    {
                        r = 0;
                    }
                    bubble_sort();
                    if (j==0)
                    { 
                        j = 1;
                    }
                    else if (j==1)
                    {
                        j = 2;
                    }
                    else if(j==2)
                    {
                        j = 0;
                        r++;
                    }

                   
                }
                else if (Set_Sort == 6)
                {
                    ShellSort();
                }
            }else
            {
                Simple_sort();
            }
               
            

            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about_panel.Visible = about_panel.Visible ? false : true;
            about_panel.BringToFront();
        }


        private void Aboout_Button_Click(object sender, EventArgs e)
        {
            about_panel.Visible = false;
        }

        private void Menu_Button_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            Menu_Button.Visible = false;
            radioButton2.Visible = true;
            radioButton1.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            radioButton6.Visible = true;
            simpsort_text.Visible = true;
            effsort_text.Visible = true;
            bubsort_text.Visible = true;
            choose_text.Visible = true;
            Next_Button.Visible = true;
        }

       

        private void Next_Button_Click(object sender, EventArgs e)
        {
            bool kellvalasztani = true;
            if (radioButton1.Checked)
            {
                Set_Sort = 1;
                kellvalasztani = true;
            }
            else if (radioButton2.Checked)
            {
                Set_Sort = 2;
                j = 1;
                kellvalasztani = true;
            }
            else if (radioButton3.Checked)
            {
                Set_Sort = 3;
                kellvalasztani = true;
            }
            else if (radioButton4.Checked)
            {
                Set_Sort = 4;
                kellvalasztani = true;
            }
            else if(radioButton5.Checked)
            {
                Set_Sort = 5;
                kellvalasztani = true;
            }
            else if(radioButton6.Checked)
            {
                Set_Sort = 6;
                kellvalasztani = true;
            }
            else
            {

                MessageBox.Show("You must choose one!");
                kellvalasztani = false;
            }
            if (kellvalasztani)
            {
                Menu_Panel.Visible = false;
                radioButton2.Visible = false;
                radioButton1.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                simpsort_text.Visible = false;
                effsort_text.Visible = false;
                bubsort_text.Visible = false;
                choose_text.Visible = false;
                Next_Button.Visible = false;
            }
        }

        private void selectionSortToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Set_Sort = 1;
        }

        private void insertionSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Set_Sort = 2;
        }

        private void heapSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Set_Sort = 3;
        }

        private void mergeSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Set_Sort = 4;
        }

        private void bubbleSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Set_Sort = 5;
        }

        private void shellSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Set_Sort = 6;
        }
    }
}
