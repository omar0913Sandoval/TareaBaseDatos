﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Conexion
{

    public partial class FrmLogin : Form
    {
        int cont = 3;

        Conectar con;
        MDI mDI;
        BackgroundWorker bg = new BackgroundWorker();
        public FrmLogin()
        {
            InitializeComponent();
        }

       private void bg_DoWork(object sender,EventArgs e)
        {
            int progreso = 0,porciento=0;


            for (int i = 0; i <= 100; i++)
            {
                progreso++;
                Thread.Sleep(50);
                bg.ReportProgress(i); 
            }
        }

        private void bg_ProgressChanged(object sender,ProgressChangedEventArgs e)
        {
            Barra.Value = e.ProgressPercentage;
            Barra.Style = ProgressBarStyle.Continuous;


            if (e.ProgressPercentage > 100)
            {
                Barra.Value = Barra.Maximum;
            }
            else
            {
                Barra.Value = e.ProgressPercentage;
            }
            
        }

        private void bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            mDI = new MDI(con);

            mDI.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {//-------------------------------------------------

           
            Cursor.Current = Cursors.WaitCursor;

            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("No pueden haber campos vacios", "Alerta");
                Cursor.Current = Cursors.Default;
                return;
            }
          
            con = new Conectar(textBox1.Text, textBox2.Text);
            if (this.con.connect.State == ConnectionState.Open)
            {

                bg.WorkerReportsProgress = true;
                bg.ProgressChanged += bg_ProgressChanged;
                bg.DoWork += bg_DoWork;
                bg.RunWorkerCompleted += bg_RunWorkerCompleted;
                bg.RunWorkerAsync();
                Barra.Visible = true;
            }
            else
            {
                Cursor.Current = Cursors.Default;
                --cont;
                MessageBox.Show("Error:usuario o contrasenia incorrecta ", cont + " Intentos restantes");
                if (cont == 0)
                {
                    cont = 3;
                    button1.Enabled = false;
                    Thread.Sleep(3000);
                    button1.Enabled = true;
                }
            }
        }//--------------------------------
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
