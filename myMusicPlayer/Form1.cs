using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myMusicPlayer
{
    public partial class Form1 : Form
    {
        Point mousePoint;
        bool mouseDown, isPlay = false, isOne = false;
        string[] nameMusic, _pathMusic;
        List<string> _nameMusic = new List<string>();
        List<string> pathMusic = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimise(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

            //Form1 form
        }



        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = e.Location;
            mouseDown = true;
            //this.Location = new Point(this.Location.X + mousePoint.X +300 , this.Location.Y + mousePoint.Y + 100);

        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int xDiff = mousePoint.X - e.Location.X;
                int yDiff = mousePoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);


            }


        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void lstAhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(isPlay==true && lstAhang.SelectedIndex >= 0)
            {
                if (axWindowsMediaPlayer1.URL != pathMusic[lstAhang.SelectedIndex])
                {
                    isOne = false;
                }
                else
                {
                    isOne = true;
                }

            }
            else
            {
                isOne = false;
            }
            
        }

        private void lstAhang_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            playOne();
        }

        private void btnControler(object sender, EventArgs e)
        {
            if (lstAhang.SelectedIndex != -1)
            {
                if (((Button)sender).Name == "btnplay")
                {
                    if (isOne == false)
                    {
                        playOne();


                    }
                    else if (isPlay == false)
                    {
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        btnplay.BackgroundImage = Properties.Resources.equal_button__1_;
                        isPlay = true;
                    }
                    else
                    {
                        axWindowsMediaPlayer1.Ctlcontrols.pause();
                        btnplay.BackgroundImage = Properties.Resources.play_button__1_;
                        isPlay = false;
                    }


                }
                else if (((Button)sender).Name == "btnBack")
                {
                    if (lstAhang.SelectedIndex >= 1)
                    {
                        axWindowsMediaPlayer1.URL = pathMusic[lstAhang.SelectedIndex - 1];
                        lstAhang.SetSelected(lstAhang.SelectedIndex - 1, true);

                    }
                    else
                    {
                        int a = lstAhang.Items.Count - 1;
                        axWindowsMediaPlayer1.URL = pathMusic[a];
                        lstAhang.SetSelected(a, true);
                    }
                }
                else if (((Button)sender).Name == "btnNext")
                {
                    if (lstAhang.SelectedIndex < lstAhang.Items.Count -1)
                    {
                        axWindowsMediaPlayer1.URL = pathMusic[lstAhang.SelectedIndex + 1];
                        lstAhang.SetSelected(lstAhang.SelectedIndex + 1, true);

                    }
                    else
                    {
                        int a = 0;
                        axWindowsMediaPlayer1.URL = pathMusic[a];
                        lstAhang.SetSelected(a, true);
                    }
                }
                else if (((Button)sender).Name == "btnStop")
                {
                    axWindowsMediaPlayer1.Ctlcontrols.stop();
                    btnplay.BackgroundImage = Properties.Resources.play_button__1_;
                    isOne = false;
                }
            }
        }

        private void addAndRemov(object sender, EventArgs e)
        {

            if (((Button)sender).Name == "btnAddDirectory")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "all mp3 (*.mp3)|*.mp3";
                ofd.Multiselect = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _pathMusic = ofd.FileNames;
                    for(int i = 0;i<_pathMusic.Length;i++)
                    {
                        string a = _pathMusic[i];
                        pathMusic.Add(a);
                    }
                    nameMusic = ofd.SafeFileNames;
                    for (int i = 0; i < nameMusic.Length; i++)
                    {
                        string a = nameMusic[i];
                        _nameMusic.Add(a);
                    }
                    for(int i = 0; i<_nameMusic.Count; i++)
                    {
                        string name = _nameMusic[i];
                        lstAhang.Items.Add(name);
                    }


                    for (int i = 0; i <= _nameMusic.Count; i++)
                    {
                        if (i == 1)
                            _nameMusic.Remove(_nameMusic[i - 1]);

                        else
                            _nameMusic.Remove(_nameMusic[i]);


                    }


                }
            }
            else
            {
                if (axWindowsMediaPlayer1.URL != pathMusic[lstAhang.SelectedIndex])
                {
                    int a = lstAhang.SelectedIndex;
                    if (a != -1)
                    {

                        lstAhang.Items.RemoveAt(a);
                        pathMusic.RemoveAt(a);


                    }
                }
                else
                {
                    MessageBox.Show("نمی توان اهنگ در حال پخش را حذف کرد", " هشدار", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
               
            }
        }
   
    
     private void playOne()
        {
            axWindowsMediaPlayer1.URL = pathMusic[lstAhang.SelectedIndex];
            btnplay.BackgroundImage = Properties.Resources.equal_button__1_;
            isOne = true;
            isPlay = true;
        }
    }
}
