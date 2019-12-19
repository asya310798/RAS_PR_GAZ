﻿using Microsoft.SolverFoundation.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RAS_PR_GAZ
{
    public partial class frMain : Form
    {

        ModelDP _mdp = new ModelDP();
        public frMain()
        {
            InitializeComponent();
        }

        private void frMain_Load(object sender, EventArgs e)
        {
            //скрываем вкладки
            tPGraph.Parent = null;
            // Где будем искать .xml-файл с исходными данными 
            FileInfo fileDefaultUserAppDataPath = new FileInfo(Application.UserAppDataPath.ToString() + @"\\default.xml");

            if (fileDefaultUserAppDataPath.Exists)  // если файл найден, то десериализовать его
            {
                //NumberSumDll.cSum ss = new NumberSumDll.cSum();
                //this.s = ss.LoadData(fileDefaultUserAppDataPath.ToString());
            }
            else  // если файла нет, то сформировать его и сериализовать в указанный каталог для последующего вызова
            {
                #region -- Загрузка первоначальных значений
               
                // ДП-1
                _mdp.Rashod_PG_base_DP_1 = 15000d;
                _mdp.Rashod_PG_base_DPmin_1 = 10000d;
                _mdp.Rashod_PG_base_DPmax_1 = 20000d;
                _mdp.Rashod_K_base_DP_1 = 64.25d;

                _mdp.Rashod_K_base_DP_E_1 = 0.59d;
                _mdp.Proizvoditelnost_chug_base_DP_1 = 146.4d;
                _mdp.Teor_t_base_DP_1 = 1938d;
                _mdp.Teor_t_base_DPmin_1 = 1900d;
                _mdp.Teor_t_base_DPmax_1 = 2100d;

                _mdp.Proiz_chug_iz_PG_DP_1 =  -0.0007295d;
                _mdp.Proiz_chug_uvel_K_DP_1 = -0.00297;
                _mdp.Iz_t_uvel_pg_DP_1 =      -0.0265;

                



                // ДП-2
                _mdp.Rashod_PG_base_DP_2 = 17000d;
                _mdp.Rashod_PG_base_DPmin_2 = 10000d;
                _mdp.Rashod_PG_base_DPmax_2 = 20000d;
                _mdp.Rashod_K_base_DP_2 = 66.76d;

                _mdp.Rashod_K_base_DP_E_2 = 0.53d;
                _mdp.Proizvoditelnost_chug_base_DP_2 = 136.4d;
                _mdp.Teor_t_base_DP_2 = 1959d;
                _mdp.Teor_t_base_DPmin_2 = 1900d;
                _mdp.Teor_t_base_DPmax_2 = 2100d;
                    
                _mdp.Proiz_chug_iz_PG_DP_2 = -0.0006695;
                _mdp.Proiz_chug_uvel_K_DP_2 = -0.00297;
                _mdp.Iz_t_uvel_pg_DP_2 = -0.0356;

                
                // ДП-3
                _mdp.Rashod_PG_base_DP_3 = 11000d;
                _mdp.Rashod_PG_base_DPmin_3 = 10000d;
                _mdp.Rashod_PG_base_DPmax_3 = 20000d;
                _mdp.Rashod_K_base_DP_3 = 56.08d;
                    
                _mdp.Rashod_K_base_DP_E_3 = 0.85d;
                _mdp.Proizvoditelnost_chug_base_DP_3 = 134.3d;
                _mdp.Teor_t_base_DP_3 = 2091d;
                _mdp.Teor_t_base_DPmin_3 = 1900d;
                _mdp.Teor_t_base_DPmax_3 = 2100d;
                    
                _mdp.Proiz_chug_iz_PG_DP_3 = 0d;
                _mdp.Proiz_chug_uvel_K_DP_3 = -0.002928;
                _mdp.Iz_t_uvel_pg_DP_3 = -0.038;
                
                // ДП-4
                _mdp.Rashod_PG_base_DP_4 = 13000d;
                _mdp.Rashod_PG_base_DPmin_4 = 10000d;
                _mdp.Rashod_PG_base_DPmax_4 = 20000d;
                _mdp.Rashod_K_base_DP_4 = 49.78d;

                _mdp.Rashod_K_base_DP_E_4 = 0.59d;
                _mdp.Proizvoditelnost_chug_base_DP_4 = 122.3d;
                _mdp.Teor_t_base_DP_4 = 1990d;
                _mdp.Teor_t_base_DPmin_4 = 1900d;
                _mdp.Teor_t_base_DPmax_4 = 2100d;
                    
                _mdp.Proiz_chug_iz_PG_DP_4 = -0.00072373d;
                _mdp.Proiz_chug_uvel_K_DP_4 = -0.002897;
                _mdp.Iz_t_uvel_pg_DP_4 = -0.0334;
                
                // ДП-5
                _mdp.Rashod_PG_base_DP_5 = 12000d;
                _mdp.Rashod_PG_base_DPmin_5 = 10000d;
                _mdp.Rashod_PG_base_DPmax_5 = 20000d;
                _mdp.Rashod_K_base_DP_5 = 62.92d;
                    
                _mdp.Rashod_K_base_DP_E_5 = 0.75d;
                _mdp.Proizvoditelnost_chug_base_DP_5 = 138.2d;
                _mdp.Teor_t_base_DP_5 = 1997d;
                _mdp.Teor_t_base_DPmin_5 = 1900d;
                _mdp.Teor_t_base_DPmax_5 = 2100d;
                    
                _mdp.Proiz_chug_iz_PG_DP_5 = -0.0007724d;
                _mdp.Proiz_chug_uvel_K_DP_5 = -0.00297;
                _mdp.Iz_t_uvel_pg_DP_5 = -0.02984;
                // ДП-6
                _mdp.Rashod_PG_base_DP_6 = 15000d;
                _mdp.Rashod_PG_base_DPmin_6 = 10000d;
                _mdp.Rashod_PG_base_DPmax_6 = 20000d;
                _mdp.Rashod_K_base_DP_6 = 60.02d;
                    
                _mdp.Rashod_K_base_DP_E_6 = 0.79d;
                _mdp.Proizvoditelnost_chug_base_DP_6 = 138.8d;
                _mdp.Teor_t_base_DP_6 = 1925d;
                _mdp.Teor_t_base_DPmin_6 = 1900d;
                _mdp.Teor_t_base_DPmax_6 = 2100d;
                    
                _mdp.Proiz_chug_iz_PG_DP_6 = -0.0006872d;
                _mdp.Proiz_chug_uvel_K_DP_6 = -0.00297;
                _mdp.Iz_t_uvel_pg_DP_6 = -0.0314;
                // ДП-7
                _mdp.Rashod_PG_base_DP_7 = 17000d;
                _mdp.Rashod_PG_base_DPmin_7 = 10000d;
                _mdp.Rashod_PG_base_DPmax_7 = 20000d;
                _mdp.Rashod_K_base_DP_7 = 81.68d;
                    
                _mdp.Rashod_K_base_DP_E_7 = 0.87d;
                _mdp.Proizvoditelnost_chug_base_DP_7 = 191.4d;
                _mdp.Teor_t_base_DP_7 = 1974d;
                _mdp.Teor_t_base_DPmin_7 = 1900d;
                _mdp.Teor_t_base_DPmax_7 = 2100d;
                    
                _mdp.Proiz_chug_iz_PG_DP_7 = -0.0007284d;
                _mdp.Proiz_chug_uvel_K_DP_7 = -0.003316;
                _mdp.Iz_t_uvel_pg_DP_7 = -0.0223;
                // ДП-8
                _mdp.Rashod_PG_base_DP_8 = 14000d;
                _mdp.Rashod_PG_base_DPmin_8 = 10000d;
                _mdp.Rashod_PG_base_DPmax_8 = 20000d;
                _mdp.Rashod_K_base_DP_8 = 69.7d;
                    
                _mdp.Rashod_K_base_DP_E_8 = 0.77d;
                _mdp.Proizvoditelnost_chug_base_DP_8 = 151.6d;
                _mdp.Teor_t_base_DP_8 = 1982d;
                _mdp.Teor_t_base_DPmin_8 = 1900d;
                _mdp.Teor_t_base_DPmax_8 = 2100d;
                    
                _mdp.Proiz_chug_iz_PG_DP_8 = -0.0007305d;
                _mdp.Proiz_chug_uvel_K_DP_8 = -0.00356;
                _mdp.Iz_t_uvel_pg_DP_8 = -0.0244;

                //параметры
                _mdp.Stoimoct_k = 1.8d;
                _mdp.Stoimoct_pg = 0.6d;
                _mdp.Rezerf_rashod_pg = 120000d;
                _mdp.Zapas_k = 520d;
                _mdp.Treb_proiz_chug = 1100d;

                #endregion -- Загрузка первоначальных значений

                // Сохранить параметры доступа к базе данных на диск для последующего вызова
                //s.SaveData(s, fileDefaultUserAppDataPath.ToString());
            }
            #region---
            //Для ДП1
            txtRashod_PG_base_DP_1.Text = _mdp.Rashod_PG_base_DP_1.ToString();
            txtRashod_PG_base_DPmin_1.Text = _mdp.Rashod_PG_base_DPmin_1.ToString();
            txtRashod_PG_base_DPmax_1.Text = _mdp.Rashod_PG_base_DPmax_1.ToString();
            txtRashod_K_base_DP_1.Text = _mdp.Rashod_K_base_DP_1.ToString();
            txtRashod_K_base_DP_E_1.Text = _mdp.Rashod_K_base_DP_E_1.ToString();
            txtProizvoditelnost_chug_base_DP_1.Text = _mdp.Proizvoditelnost_chug_base_DP_1.ToString();
            txtTeor_t_base_DP_1.Text = _mdp.Teor_t_base_DP_1.ToString();
            txtTeor_t_base_DPmin_1.Text = _mdp.Teor_t_base_DPmin_1.ToString();
            txtTeor_t_base_DPmax_1.Text = _mdp.Teor_t_base_DPmax_1.ToString();
            
            txtProiz_chug_iz_PG_DP_1.Text = _mdp.Proiz_chug_iz_PG_DP_1.ToString();
            txtProiz_chug_uvel_K_DP_1.Text = _mdp.Proiz_chug_uvel_K_DP_1.ToString();
            txtIz_t_uvel_pg_DP_1.Text = _mdp.Iz_t_uvel_pg_DP_1.ToString();

            //Для ДП2
            txtRashod_PG_base_DP_2.Text = _mdp.Rashod_PG_base_DP_2.ToString();
            txtRashod_PG_base_DPmin_2.Text = _mdp.Rashod_PG_base_DPmin_2.ToString();
            txtRashod_PG_base_DPmax_2.Text = _mdp.Rashod_PG_base_DPmax_2.ToString();
            txtRashod_K_base_DP_2.Text = _mdp.Rashod_K_base_DP_2.ToString();
            txtRashod_K_base_DP_E_2.Text = _mdp.Rashod_K_base_DP_E_2.ToString();
            txtProizvoditelnost_chug_base_DP_2.Text = _mdp.Proizvoditelnost_chug_base_DP_2.ToString();
            txtTeor_t_base_DP_2.Text = _mdp.Teor_t_base_DP_2.ToString();
            txtTeor_t_base_DPmin_2.Text = _mdp.Teor_t_base_DPmin_2.ToString();
            txtTeor_t_base_DPmax_2.Text = _mdp.Teor_t_base_DPmax_2.ToString();

            txtProiz_chug_iz_PG_DP_2.Text = _mdp.Proiz_chug_iz_PG_DP_2.ToString();
            txtProiz_chug_uvel_K_DP_2.Text = _mdp.Proiz_chug_uvel_K_DP_2.ToString();
            txtIz_t_uvel_pg_DP_2.Text = _mdp.Iz_t_uvel_pg_DP_2.ToString();

            //Для ДП3
            txtRashod_PG_base_DP_3.Text = _mdp.Rashod_PG_base_DP_3.ToString();
            txtRashod_PG_base_DPmin_3.Text = _mdp.Rashod_PG_base_DPmin_3.ToString();
            txtRashod_PG_base_DPmax_3.Text = _mdp.Rashod_PG_base_DPmax_3.ToString();
            txtRashod_K_base_DP_3.Text = _mdp.Rashod_K_base_DP_3.ToString();
            txtRashod_K_base_DP_E_3.Text = _mdp.Rashod_K_base_DP_E_3.ToString();
            txtProizvoditelnost_chug_base_DP_3.Text = _mdp.Proizvoditelnost_chug_base_DP_3.ToString();
            txtTeor_t_base_DP_3.Text = _mdp.Teor_t_base_DP_3.ToString();
            txtTeor_t_base_DPmin_3.Text = _mdp.Teor_t_base_DPmin_3.ToString();
            txtTeor_t_base_DPmax_3.Text = _mdp.Teor_t_base_DPmax_3.ToString();

            txtProiz_chug_iz_PG_DP_3.Text = _mdp.Proiz_chug_iz_PG_DP_3.ToString();
            txtProiz_chug_uvel_K_DP_3.Text = _mdp.Proiz_chug_uvel_K_DP_3.ToString();
            txtIz_t_uvel_pg_DP_3.Text = _mdp.Iz_t_uvel_pg_DP_3.ToString();

            //Для ДП4
            txtRashod_PG_base_DP_4.Text = _mdp.Rashod_PG_base_DP_4.ToString();
            txtRashod_PG_base_DPmin_4.Text = _mdp.Rashod_PG_base_DPmin_4.ToString();
            txtRashod_PG_base_DPmax_4.Text = _mdp.Rashod_PG_base_DPmax_4.ToString();
            txtRashod_K_base_DP_4.Text = _mdp.Rashod_K_base_DP_4.ToString();
            txtRashod_K_base_DP_E_4.Text = _mdp.Rashod_K_base_DP_E_4.ToString();
            txtProizvoditelnost_chug_base_DP_4.Text = _mdp.Proizvoditelnost_chug_base_DP_4.ToString();
            txtTeor_t_base_DP_4.Text = _mdp.Teor_t_base_DP_4.ToString();
            txtTeor_t_base_DPmin_4.Text = _mdp.Teor_t_base_DPmin_4.ToString();
            txtTeor_t_base_DPmax_4.Text = _mdp.Teor_t_base_DPmax_4.ToString();

            txtProiz_chug_iz_PG_DP_4.Text = _mdp.Proiz_chug_iz_PG_DP_4.ToString();
            txtProiz_chug_uvel_K_DP_4.Text = _mdp.Proiz_chug_uvel_K_DP_4.ToString();
            txtIz_t_uvel_pg_DP_4.Text = _mdp.Iz_t_uvel_pg_DP_4.ToString();

            //Для ДП5
            txtRashod_PG_base_DP_5.Text = _mdp.Rashod_PG_base_DP_5.ToString();
            txtRashod_PG_base_DPmin_5.Text = _mdp.Rashod_PG_base_DPmin_5.ToString();
            txtRashod_PG_base_DPmax_5.Text = _mdp.Rashod_PG_base_DPmax_5.ToString();
            txtRashod_K_base_DP_5.Text = _mdp.Rashod_K_base_DP_5.ToString();
            txtRashod_K_base_DP_E_5.Text = _mdp.Rashod_K_base_DP_E_5.ToString();
            txtProizvoditelnost_chug_base_DP_5.Text = _mdp.Proizvoditelnost_chug_base_DP_5.ToString();
            txtTeor_t_base_DP_5.Text = _mdp.Teor_t_base_DP_5.ToString();
            txtTeor_t_base_DPmin_5.Text = _mdp.Teor_t_base_DPmin_5.ToString();
            txtTeor_t_base_DPmax_5.Text = _mdp.Teor_t_base_DPmax_5.ToString();

            txtProiz_chug_iz_PG_DP_5.Text = _mdp.Proiz_chug_iz_PG_DP_5.ToString();
            txtProiz_chug_uvel_K_DP_5.Text = _mdp.Proiz_chug_uvel_K_DP_5.ToString();
            txtIz_t_uvel_pg_DP_5.Text = _mdp.Iz_t_uvel_pg_DP_5.ToString();

            //Для ДП6
            txtRashod_PG_base_DP_6.Text = _mdp.Rashod_PG_base_DP_6.ToString();
            txtRashod_PG_base_DPmin_6.Text = _mdp.Rashod_PG_base_DPmin_6.ToString();
            txtRashod_PG_base_DPmax_6.Text = _mdp.Rashod_PG_base_DPmax_6.ToString();
            txtRashod_K_base_DP_6.Text = _mdp.Rashod_K_base_DP_6.ToString();
            txtRashod_K_base_DP_E_6.Text = _mdp.Rashod_K_base_DP_E_6.ToString();
            txtProizvoditelnost_chug_base_DP_6.Text = _mdp.Proizvoditelnost_chug_base_DP_6.ToString();
            txtTeor_t_base_DP_6.Text = _mdp.Teor_t_base_DP_6.ToString();
            txtTeor_t_base_DPmin_6.Text = _mdp.Teor_t_base_DPmin_6.ToString();
            txtTeor_t_base_DPmax_6.Text = _mdp.Teor_t_base_DPmax_6.ToString();

            txtProiz_chug_iz_PG_DP_6.Text = _mdp.Proiz_chug_iz_PG_DP_6.ToString();
            txtProiz_chug_uvel_K_DP_6.Text = _mdp.Proiz_chug_uvel_K_DP_6.ToString();
            txtIz_t_uvel_pg_DP_6.Text = _mdp.Iz_t_uvel_pg_DP_6.ToString();

            //Для ДП7
            txtRashod_PG_base_DP_7.Text = _mdp.Rashod_PG_base_DP_7.ToString();
            txtRashod_PG_base_DPmin_7.Text = _mdp.Rashod_PG_base_DPmin_7.ToString();
            txtRashod_PG_base_DPmax_7.Text = _mdp.Rashod_PG_base_DPmax_7.ToString();
            txtRashod_K_base_DP_7.Text = _mdp.Rashod_K_base_DP_7.ToString();
            txtRashod_K_base_DP_E_7.Text = _mdp.Rashod_K_base_DP_E_7.ToString();
            txtProizvoditelnost_chug_base_DP_7.Text = _mdp.Proizvoditelnost_chug_base_DP_7.ToString();
            txtTeor_t_base_DP_7.Text = _mdp.Teor_t_base_DP_7.ToString();
            txtTeor_t_base_DPmin_7.Text = _mdp.Teor_t_base_DPmin_7.ToString();
            txtTeor_t_base_DPmax_7.Text = _mdp.Teor_t_base_DPmax_7.ToString();

            txtProiz_chug_iz_PG_DP_7.Text = _mdp.Proiz_chug_iz_PG_DP_7.ToString();
            txtProiz_chug_uvel_K_DP_7.Text = _mdp.Proiz_chug_uvel_K_DP_7.ToString();
            txtIz_t_uvel_pg_DP_7.Text = _mdp.Iz_t_uvel_pg_DP_7.ToString();

            //Для ДП8
            txtRashod_PG_base_DP_8.Text = _mdp.Rashod_PG_base_DP_8.ToString();
            txtRashod_PG_base_DPmin_8.Text = _mdp.Rashod_PG_base_DPmin_8.ToString();
            txtRashod_PG_base_DPmax_8.Text = _mdp.Rashod_PG_base_DPmax_8.ToString();
            txtRashod_K_base_DP_8.Text = _mdp.Rashod_K_base_DP_8.ToString();
            txtRashod_K_base_DP_E_8.Text = _mdp.Rashod_K_base_DP_E_8.ToString();
            txtProizvoditelnost_chug_base_DP_8.Text = _mdp.Proizvoditelnost_chug_base_DP_8.ToString();
            txtTeor_t_base_DP_8.Text = _mdp.Teor_t_base_DP_8.ToString();
            txtTeor_t_base_DPmin_8.Text = _mdp.Teor_t_base_DPmin_8.ToString();
            txtTeor_t_base_DPmax_8.Text = _mdp.Teor_t_base_DPmax_8.ToString();

            txtProiz_chug_iz_PG_DP_8.Text = _mdp.Proiz_chug_iz_PG_DP_8.ToString();
            txtProiz_chug_uvel_K_DP_8.Text = _mdp.Proiz_chug_uvel_K_DP_8.ToString();
            txtIz_t_uvel_pg_DP_8.Text = _mdp.Iz_t_uvel_pg_DP_8.ToString();

            txtStoimoct_k.Text = _mdp.Stoimoct_k.ToString();
            txtStoimoct_pg.Text = _mdp.Stoimoct_pg.ToString();
            txtRezerf_rashod_pg.Text = _mdp.Rezerf_rashod_pg.ToString();
            txtZapas_k.Text = _mdp.Zapas_k.ToString();
            txtTreb_proiz_chug.Text = _mdp.Treb_proiz_chug.ToString();
            #endregion---
            
        }



        private void btnCalc_Click(object sender, EventArgs e)
        {
            //очищаем
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            //при нажатии на кнопку, открывается вкладка
            tPGraph.Parent = tab;

            List<ModelDP> modelDPs = new List<ModelDP>();
            #region -- Загрузка первоначальных значений

            // ДП-1
            _mdp.Rashod_PG_base_DP_1 = Double.Parse(txtRashod_PG_base_DP_1.Text);
            _mdp.Rashod_PG_base_DPmin_1 = Double.Parse(txtRashod_PG_base_DPmin_1.Text);
            _mdp.Rashod_PG_base_DPmax_1 = Double.Parse(txtRashod_PG_base_DPmax_1.Text);
            _mdp.Rashod_K_base_DP_1 = Double.Parse(txtRashod_K_base_DP_1.Text);


            _mdp.Rashod_K_base_DP_E_1 = Double.Parse(txtRashod_K_base_DP_E_1.Text);
            _mdp.Proizvoditelnost_chug_base_DP_1 = Double.Parse(txtProizvoditelnost_chug_base_DP_1.Text);
            _mdp.Teor_t_base_DP_1 = Double.Parse(txtTeor_t_base_DP_1.Text);
            _mdp.Teor_t_base_DPmin_1 = Double.Parse(txtTeor_t_base_DPmin_1.Text);
            _mdp.Teor_t_base_DPmax_1 = Double.Parse(txtTeor_t_base_DPmax_1.Text);

            _mdp.Proiz_chug_iz_PG_DP_1 = Double.Parse(txtProiz_chug_iz_PG_DP_1.Text);
            _mdp.Proiz_chug_uvel_K_DP_1 = Double.Parse(txtProiz_chug_uvel_K_DP_1.Text);
            _mdp.Iz_t_uvel_pg_DP_1 = Double.Parse(txtIz_t_uvel_pg_DP_1.Text);





            // ДП-2
            _mdp.Rashod_PG_base_DP_2 = Double.Parse(txtRashod_PG_base_DP_2.Text);
            _mdp.Rashod_PG_base_DPmin_2 = Double.Parse(txtRashod_PG_base_DPmin_2.Text);
            _mdp.Rashod_PG_base_DPmax_2 = Double.Parse(txtRashod_PG_base_DPmax_2.Text);
            _mdp.Rashod_K_base_DP_2 = Double.Parse(txtRashod_K_base_DP_2.Text);


            _mdp.Rashod_K_base_DP_E_2 = Double.Parse(txtRashod_K_base_DP_E_2.Text);
            _mdp.Proizvoditelnost_chug_base_DP_2 = Double.Parse(txtProizvoditelnost_chug_base_DP_2.Text);
            _mdp.Teor_t_base_DP_2 = Double.Parse(txtTeor_t_base_DP_2.Text);
            _mdp.Teor_t_base_DPmin_2 = Double.Parse(txtTeor_t_base_DPmin_2.Text);
            _mdp.Teor_t_base_DPmax_2 = Double.Parse(txtTeor_t_base_DPmax_2.Text);

            _mdp.Proiz_chug_iz_PG_DP_2 = Double.Parse(txtProiz_chug_iz_PG_DP_2.Text);
            _mdp.Proiz_chug_uvel_K_DP_2 = Double.Parse(txtProiz_chug_uvel_K_DP_2.Text);
            _mdp.Iz_t_uvel_pg_DP_2 = Double.Parse(txtIz_t_uvel_pg_DP_2.Text);


            // ДП-3
            _mdp.Rashod_PG_base_DP_3 = Double.Parse(txtRashod_PG_base_DP_3.Text);
            _mdp.Rashod_PG_base_DPmin_3 = Double.Parse(txtRashod_PG_base_DPmin_3.Text);
            _mdp.Rashod_PG_base_DPmax_3 = Double.Parse(txtRashod_PG_base_DPmax_3.Text);
            _mdp.Rashod_K_base_DP_3 = Double.Parse(txtRashod_K_base_DP_3.Text);


            _mdp.Rashod_K_base_DP_E_3 = Double.Parse(txtRashod_K_base_DP_E_3.Text);
            _mdp.Proizvoditelnost_chug_base_DP_3 = Double.Parse(txtProizvoditelnost_chug_base_DP_3.Text);
            _mdp.Teor_t_base_DP_3 = Double.Parse(txtTeor_t_base_DP_3.Text);
            _mdp.Teor_t_base_DPmin_3 = Double.Parse(txtTeor_t_base_DPmin_3.Text);
            _mdp.Teor_t_base_DPmax_3 = Double.Parse(txtTeor_t_base_DPmax_3.Text);

            _mdp.Proiz_chug_iz_PG_DP_3 = Double.Parse(txtProiz_chug_iz_PG_DP_3.Text);
            _mdp.Proiz_chug_uvel_K_DP_3 = Double.Parse(txtProiz_chug_uvel_K_DP_3.Text);
            _mdp.Iz_t_uvel_pg_DP_3 = Double.Parse(txtIz_t_uvel_pg_DP_3.Text);

            // ДП-4
            _mdp.Rashod_PG_base_DP_4 = Double.Parse(txtRashod_PG_base_DP_4.Text);
            _mdp.Rashod_PG_base_DPmin_4 = Double.Parse(txtRashod_PG_base_DPmin_4.Text);
            _mdp.Rashod_PG_base_DPmax_4 = Double.Parse(txtRashod_PG_base_DPmax_4.Text);
            _mdp.Rashod_K_base_DP_4 = Double.Parse(txtRashod_K_base_DP_4.Text);


            _mdp.Rashod_K_base_DP_E_4 = Double.Parse(txtRashod_K_base_DP_E_4.Text);
            _mdp.Proizvoditelnost_chug_base_DP_4 = Double.Parse(txtProizvoditelnost_chug_base_DP_4.Text);
            _mdp.Teor_t_base_DP_4 = Double.Parse(txtTeor_t_base_DP_4.Text);
            _mdp.Teor_t_base_DPmin_4 = Double.Parse(txtTeor_t_base_DPmin_4.Text);
            _mdp.Teor_t_base_DPmax_4 = Double.Parse(txtTeor_t_base_DPmax_4.Text);

            _mdp.Proiz_chug_iz_PG_DP_4 = Double.Parse(txtProiz_chug_iz_PG_DP_4.Text);
            _mdp.Proiz_chug_uvel_K_DP_4 = Double.Parse(txtProiz_chug_uvel_K_DP_4.Text);
            _mdp.Iz_t_uvel_pg_DP_4 = Double.Parse(txtIz_t_uvel_pg_DP_4.Text);

            // ДП-5
            _mdp.Rashod_PG_base_DP_5 = Double.Parse(txtRashod_PG_base_DP_5.Text);
            _mdp.Rashod_PG_base_DPmin_5 = Double.Parse(txtRashod_PG_base_DPmin_5.Text);
            _mdp.Rashod_PG_base_DPmax_5 = Double.Parse(txtRashod_PG_base_DPmax_5.Text);
            _mdp.Rashod_K_base_DP_5 = Double.Parse(txtRashod_K_base_DP_5.Text);


            _mdp.Rashod_K_base_DP_E_5 = Double.Parse(txtRashod_K_base_DP_E_5.Text);
            _mdp.Proizvoditelnost_chug_base_DP_5 = Double.Parse(txtProizvoditelnost_chug_base_DP_5.Text);
            _mdp.Teor_t_base_DP_5 = Double.Parse(txtTeor_t_base_DP_5.Text);
            _mdp.Teor_t_base_DPmin_5 = Double.Parse(txtTeor_t_base_DPmin_5.Text);
            _mdp.Teor_t_base_DPmax_5 = Double.Parse(txtTeor_t_base_DPmax_5.Text);

            _mdp.Proiz_chug_iz_PG_DP_5 = Double.Parse(txtProiz_chug_iz_PG_DP_5.Text);
            _mdp.Proiz_chug_uvel_K_DP_5 = Double.Parse(txtProiz_chug_uvel_K_DP_5.Text);
            _mdp.Iz_t_uvel_pg_DP_5 = Double.Parse(txtIz_t_uvel_pg_DP_5.Text);
            // ДП-6
            _mdp.Rashod_PG_base_DP_6 = Double.Parse(txtRashod_PG_base_DP_6.Text);
            _mdp.Rashod_PG_base_DPmin_6 = Double.Parse(txtRashod_PG_base_DPmin_6.Text);
            _mdp.Rashod_PG_base_DPmax_6 = Double.Parse(txtRashod_PG_base_DPmax_6.Text);
            _mdp.Rashod_K_base_DP_6 = Double.Parse(txtRashod_K_base_DP_6.Text);


            _mdp.Rashod_K_base_DP_E_6 = Double.Parse(txtRashod_K_base_DP_E_6.Text);
            _mdp.Proizvoditelnost_chug_base_DP_6 = Double.Parse(txtProizvoditelnost_chug_base_DP_6.Text);
            _mdp.Teor_t_base_DP_6 = Double.Parse(txtTeor_t_base_DP_6.Text);
            _mdp.Teor_t_base_DPmin_6 = Double.Parse(txtTeor_t_base_DPmin_6.Text);
            _mdp.Teor_t_base_DPmax_6 = Double.Parse(txtTeor_t_base_DPmax_6.Text);

            _mdp.Proiz_chug_iz_PG_DP_6 = Double.Parse(txtProiz_chug_iz_PG_DP_6.Text);
            _mdp.Proiz_chug_uvel_K_DP_6 = Double.Parse(txtProiz_chug_uvel_K_DP_6.Text);
            _mdp.Iz_t_uvel_pg_DP_6 = Double.Parse(txtIz_t_uvel_pg_DP_6.Text);
            // ДП-7
            _mdp.Rashod_PG_base_DP_7 = Double.Parse(txtRashod_PG_base_DP_7.Text);
            _mdp.Rashod_PG_base_DPmin_7 = Double.Parse(txtRashod_PG_base_DPmin_7.Text);
            _mdp.Rashod_PG_base_DPmax_7 = Double.Parse(txtRashod_PG_base_DPmax_7.Text);
            _mdp.Rashod_K_base_DP_7 = Double.Parse(txtRashod_K_base_DP_7.Text);


            _mdp.Rashod_K_base_DP_E_7 = Double.Parse(txtRashod_K_base_DP_E_7.Text);
            _mdp.Proizvoditelnost_chug_base_DP_7 = Double.Parse(txtProizvoditelnost_chug_base_DP_7.Text);
            _mdp.Teor_t_base_DP_7 = Double.Parse(txtTeor_t_base_DP_7.Text);
            _mdp.Teor_t_base_DPmin_7 = Double.Parse(txtTeor_t_base_DPmin_7.Text);
            _mdp.Teor_t_base_DPmax_7 = Double.Parse(txtTeor_t_base_DPmax_7.Text);

            _mdp.Proiz_chug_iz_PG_DP_7 = Double.Parse(txtProiz_chug_iz_PG_DP_7.Text);
            _mdp.Proiz_chug_uvel_K_DP_7 = Double.Parse(txtProiz_chug_uvel_K_DP_7.Text);
            _mdp.Iz_t_uvel_pg_DP_7 = Double.Parse(txtIz_t_uvel_pg_DP_7.Text);
            // ДП-8
            _mdp.Rashod_PG_base_DP_8 = Double.Parse(txtRashod_PG_base_DP_8.Text);
            _mdp.Rashod_PG_base_DPmin_8 = Double.Parse(txtRashod_PG_base_DPmin_8.Text);
            _mdp.Rashod_PG_base_DPmax_8 = Double.Parse(txtRashod_PG_base_DPmax_8.Text);
            _mdp.Rashod_K_base_DP_8 = Double.Parse(txtRashod_K_base_DP_8.Text);


            _mdp.Rashod_K_base_DP_E_8 = Double.Parse(txtRashod_K_base_DP_E_8.Text);
            _mdp.Proizvoditelnost_chug_base_DP_8 = Double.Parse(txtProizvoditelnost_chug_base_DP_8.Text);
            _mdp.Teor_t_base_DP_8 = Double.Parse(txtTeor_t_base_DP_8.Text);
            _mdp.Teor_t_base_DPmin_8 = Double.Parse(txtTeor_t_base_DPmin_8.Text);
            _mdp.Teor_t_base_DPmax_8 = Double.Parse(txtTeor_t_base_DPmax_8.Text);

            _mdp.Proiz_chug_iz_PG_DP_8 = Double.Parse(txtProiz_chug_iz_PG_DP_8.Text);
            _mdp.Proiz_chug_uvel_K_DP_8 = Double.Parse(txtProiz_chug_uvel_K_DP_8.Text);
            _mdp.Iz_t_uvel_pg_DP_8 = Double.Parse(txtIz_t_uvel_pg_DP_8.Text);

            //параметры
            _mdp.Stoimoct_k = Double.Parse(txtStoimoct_k.Text);
            _mdp.Stoimoct_pg = Double.Parse(txtStoimoct_pg.Text);
            _mdp.Rezerf_rashod_pg = Double.Parse(txtRezerf_rashod_pg.Text);
            _mdp.Zapas_k = Double.Parse(txtZapas_k.Text);
            _mdp.Treb_proiz_chug = Double.Parse(txtTreb_proiz_chug.Text);

            #endregion -- Загрузка первоначальных значений
            #region---
            //Для ДП1
            modelDPs.Add(new ModelDP {
                xId = 1,
                Koef = (_mdp.Rashod_K_base_DP_E_1 * _mdp.Stoimoct_k - _mdp.Stoimoct_pg),
                KoefNerav1 = (-0.001*_mdp.Rashod_K_base_DP_E_1),
                KoefNerav11 = (_mdp.Rashod_K_base_DP_1 +0.001 * _mdp.Rashod_PG_base_DP_1 * _mdp.Rashod_K_base_DP_E_1),

                KoefNerav2 = _mdp.Proiz_chug_iz_PG_DP_1-_mdp.Rashod_K_base_DP_E_1*_mdp.Proiz_chug_uvel_K_DP_1,
                KoefNerav22 = -_mdp.Rashod_PG_base_DP_1*_mdp.Proiz_chug_iz_PG_DP_1+_mdp.Rashod_K_base_DP_E_1*_mdp.Rashod_PG_base_DP_1*_mdp.Proiz_chug_uvel_K_DP_1+_mdp.Proizvoditelnost_chug_base_DP_1,

                KoefNerav3 = (_mdp.Teor_t_base_DPmin_1+_mdp.Rashod_PG_base_DP_1 * _mdp.Iz_t_uvel_pg_DP_1-_mdp.Teor_t_base_DP_1)/_mdp.Iz_t_uvel_pg_DP_1,
                KoefNerav33 = (_mdp.Teor_t_base_DPmax_1 + _mdp.Rashod_PG_base_DP_1 * _mdp.Iz_t_uvel_pg_DP_1 - _mdp.Teor_t_base_DP_1) / _mdp.Iz_t_uvel_pg_DP_1,

                Rashod_PG_base_DP = _mdp.Rashod_PG_base_DP_1,
                Rashod_PG_base_DPmin = _mdp.Rashod_PG_base_DPmin_1,
                Rashod_PG_base_DPmax = _mdp.Rashod_PG_base_DPmax_1,
                Rashod_K_base_DP = _mdp.Rashod_K_base_DP_1,
                Rashod_K_base_DP_E = _mdp.Rashod_K_base_DP_E_1,
                Proizvoditelnost_chug_base_DP = _mdp.Proizvoditelnost_chug_base_DP_1,
                Teor_t_base_DP = _mdp.Teor_t_base_DP_1,
                Teor_t_base_DPmin = _mdp.Teor_t_base_DPmin_1,
                Teor_t_base_DPmax = _mdp.Teor_t_base_DPmax_1,

                Proiz_chug_iz_PG_DP = _mdp.Proiz_chug_iz_PG_DP_1,
                Proiz_chug_uvel_K_DP = _mdp.Proiz_chug_uvel_K_DP_1,
                Iz_t_uvel_pg_DP = _mdp.Iz_t_uvel_pg_DP_1,
                


            });
            //Для ДП2
            modelDPs.Add(new ModelDP
            {
                xId = 2,
                Koef = (_mdp.Rashod_K_base_DP_E_2 * _mdp.Stoimoct_k - _mdp.Stoimoct_pg),
                KoefNerav1 = (-0.001 * _mdp.Rashod_K_base_DP_E_2),
                KoefNerav11 = (_mdp.Rashod_K_base_DP_2 + 0.001 * _mdp.Rashod_PG_base_DP_2 * _mdp.Rashod_K_base_DP_E_2),

                KoefNerav2 = _mdp.Proiz_chug_iz_PG_DP_2 - _mdp.Rashod_K_base_DP_E_2 * _mdp.Proiz_chug_uvel_K_DP_2,
                KoefNerav22 = -_mdp.Rashod_PG_base_DP_2 * _mdp.Proiz_chug_iz_PG_DP_2 + _mdp.Rashod_K_base_DP_E_2 * _mdp.Rashod_PG_base_DP_2 * _mdp.Proiz_chug_uvel_K_DP_2 + _mdp.Proizvoditelnost_chug_base_DP_2,


                KoefNerav3 = (_mdp.Teor_t_base_DPmin_2 + _mdp.Rashod_PG_base_DP_2 * _mdp.Iz_t_uvel_pg_DP_2 - _mdp.Teor_t_base_DP_2) / _mdp.Iz_t_uvel_pg_DP_2,
                KoefNerav33 = (_mdp.Teor_t_base_DPmax_2 + _mdp.Rashod_PG_base_DP_2 * _mdp.Iz_t_uvel_pg_DP_2 - _mdp.Teor_t_base_DP_2) / _mdp.Iz_t_uvel_pg_DP_2,


                Rashod_PG_base_DP = _mdp.Rashod_PG_base_DP_2,
                Rashod_PG_base_DPmin = _mdp.Rashod_PG_base_DPmin_2,
                Rashod_PG_base_DPmax = _mdp.Rashod_PG_base_DPmax_2,
                Rashod_K_base_DP = _mdp.Rashod_K_base_DP_2,
                Rashod_K_base_DP_E = _mdp.Rashod_K_base_DP_E_2,
                Proizvoditelnost_chug_base_DP = _mdp.Proizvoditelnost_chug_base_DP_2,
                Teor_t_base_DP = _mdp.Teor_t_base_DP_2,
                Teor_t_base_DPmin = _mdp.Teor_t_base_DPmin_2,
                Teor_t_base_DPmax = _mdp.Teor_t_base_DPmax_2,

                Proiz_chug_iz_PG_DP = _mdp.Proiz_chug_iz_PG_DP_2,
                Proiz_chug_uvel_K_DP = _mdp.Proiz_chug_uvel_K_DP_2,
                Iz_t_uvel_pg_DP = _mdp.Iz_t_uvel_pg_DP_2,
                
            });

            //Для ДП3
            modelDPs.Add(new ModelDP
            {
                xId = 3,
                Koef = (_mdp.Rashod_K_base_DP_E_3 * _mdp.Stoimoct_k - _mdp.Stoimoct_pg),
                KoefNerav1 = (-0.001 * _mdp.Rashod_K_base_DP_E_3),
                KoefNerav11 = (_mdp.Rashod_K_base_DP_3 + 0.001 * _mdp.Rashod_PG_base_DP_3 * _mdp.Rashod_K_base_DP_E_3),

                KoefNerav2 = _mdp.Proiz_chug_iz_PG_DP_3 - _mdp.Rashod_K_base_DP_E_3 * _mdp.Proiz_chug_uvel_K_DP_3,
                KoefNerav22 = -_mdp.Rashod_PG_base_DP_3 * _mdp.Proiz_chug_iz_PG_DP_3 + _mdp.Rashod_K_base_DP_E_3 * _mdp.Rashod_PG_base_DP_3 * _mdp.Proiz_chug_uvel_K_DP_3 + _mdp.Proizvoditelnost_chug_base_DP_3,


                KoefNerav3 = (_mdp.Teor_t_base_DPmin_3 + _mdp.Rashod_PG_base_DP_3 * _mdp.Iz_t_uvel_pg_DP_3 - _mdp.Teor_t_base_DP_3) / _mdp.Iz_t_uvel_pg_DP_3,
                KoefNerav33 = (_mdp.Teor_t_base_DPmax_3 + _mdp.Rashod_PG_base_DP_3 * _mdp.Iz_t_uvel_pg_DP_3 - _mdp.Teor_t_base_DP_3) / _mdp.Iz_t_uvel_pg_DP_3,

                Rashod_PG_base_DP = _mdp.Rashod_PG_base_DP_3,
                Rashod_PG_base_DPmin = _mdp.Rashod_PG_base_DPmin_3,
                Rashod_PG_base_DPmax = _mdp.Rashod_PG_base_DPmax_3,
                Rashod_K_base_DP = _mdp.Rashod_K_base_DP_3,
                Rashod_K_base_DP_E = _mdp.Rashod_K_base_DP_E_3,
                Proizvoditelnost_chug_base_DP = _mdp.Proizvoditelnost_chug_base_DP_3,
                Teor_t_base_DP = _mdp.Teor_t_base_DP_3,
                Teor_t_base_DPmin = _mdp.Teor_t_base_DPmin_3,
                Teor_t_base_DPmax = _mdp.Teor_t_base_DPmax_3,

                Proiz_chug_iz_PG_DP = _mdp.Proiz_chug_iz_PG_DP_3,
                Proiz_chug_uvel_K_DP = _mdp.Proiz_chug_uvel_K_DP_3,
                Iz_t_uvel_pg_DP = _mdp.Iz_t_uvel_pg_DP_3,
                
            });

            //Для ДП4
            modelDPs.Add(new ModelDP
            {
                xId = 4,
                Koef = (_mdp.Rashod_K_base_DP_E_4 * _mdp.Stoimoct_k - _mdp.Stoimoct_pg),
                KoefNerav1 = (-0.001 * _mdp.Rashod_K_base_DP_E_4),
                KoefNerav11 = (_mdp.Rashod_K_base_DP_4 + 0.001 * _mdp.Rashod_PG_base_DP_4 * _mdp.Rashod_K_base_DP_E_4),

                KoefNerav2 = _mdp.Proiz_chug_iz_PG_DP_4 - _mdp.Rashod_K_base_DP_E_4 * _mdp.Proiz_chug_uvel_K_DP_4,
                KoefNerav22 = -_mdp.Rashod_PG_base_DP_4 * _mdp.Proiz_chug_iz_PG_DP_4 + _mdp.Rashod_K_base_DP_E_4 * _mdp.Rashod_PG_base_DP_4 * _mdp.Proiz_chug_uvel_K_DP_4 + _mdp.Proizvoditelnost_chug_base_DP_4,


                KoefNerav3 = (_mdp.Teor_t_base_DPmin_4 + _mdp.Rashod_PG_base_DP_4 * _mdp.Iz_t_uvel_pg_DP_4 - _mdp.Teor_t_base_DP_4) / _mdp.Iz_t_uvel_pg_DP_4,
                KoefNerav33 = (_mdp.Teor_t_base_DPmax_4 + _mdp.Rashod_PG_base_DP_4 * _mdp.Iz_t_uvel_pg_DP_4 - _mdp.Teor_t_base_DP_4) / _mdp.Iz_t_uvel_pg_DP_4,


                Rashod_PG_base_DP = _mdp.Rashod_PG_base_DP_4,
                Rashod_PG_base_DPmin = _mdp.Rashod_PG_base_DPmin_4,
                Rashod_PG_base_DPmax = _mdp.Rashod_PG_base_DPmax_4,
                Rashod_K_base_DP = _mdp.Rashod_K_base_DP_4,
                Rashod_K_base_DP_E = _mdp.Rashod_K_base_DP_E_4,
                Proizvoditelnost_chug_base_DP = _mdp.Proizvoditelnost_chug_base_DP_4,
                Teor_t_base_DP = _mdp.Teor_t_base_DP_4,
                Teor_t_base_DPmin = _mdp.Teor_t_base_DPmin_4,
                Teor_t_base_DPmax = _mdp.Teor_t_base_DPmax_4,

                Proiz_chug_iz_PG_DP = _mdp.Proiz_chug_iz_PG_DP_4,
                Proiz_chug_uvel_K_DP = _mdp.Proiz_chug_uvel_K_DP_4,
                Iz_t_uvel_pg_DP = _mdp.Iz_t_uvel_pg_DP_4,
                
            });

            //Для ДП5
            modelDPs.Add(new ModelDP
            {
                xId = 5,
                Koef = (_mdp.Rashod_K_base_DP_E_5 * _mdp.Stoimoct_k - _mdp.Stoimoct_pg),
                KoefNerav1 = (-0.001 * _mdp.Rashod_K_base_DP_E_5),
                KoefNerav11 = (_mdp.Rashod_K_base_DP_5 + 0.001 * _mdp.Rashod_PG_base_DP_5 * _mdp.Rashod_K_base_DP_E_5),

                KoefNerav2 = _mdp.Proiz_chug_iz_PG_DP_5 - _mdp.Rashod_K_base_DP_E_5 * _mdp.Proiz_chug_uvel_K_DP_5,
                KoefNerav22 = -_mdp.Rashod_PG_base_DP_5 * _mdp.Proiz_chug_iz_PG_DP_5 + _mdp.Rashod_K_base_DP_E_5 * _mdp.Rashod_PG_base_DP_5 * _mdp.Proiz_chug_uvel_K_DP_5 + _mdp.Proizvoditelnost_chug_base_DP_5,


                KoefNerav3 = (_mdp.Teor_t_base_DPmin_5 + _mdp.Rashod_PG_base_DP_5 * _mdp.Iz_t_uvel_pg_DP_5 - _mdp.Teor_t_base_DP_5) / _mdp.Iz_t_uvel_pg_DP_5,
                KoefNerav33 = (_mdp.Teor_t_base_DPmax_5 + _mdp.Rashod_PG_base_DP_5 * _mdp.Iz_t_uvel_pg_DP_5 - _mdp.Teor_t_base_DP_5) / _mdp.Iz_t_uvel_pg_DP_5,


                Rashod_PG_base_DP = _mdp.Rashod_PG_base_DP_5,
                Rashod_PG_base_DPmin = _mdp.Rashod_PG_base_DPmin_5,
                Rashod_PG_base_DPmax = _mdp.Rashod_PG_base_DPmax_5,
                Rashod_K_base_DP = _mdp.Rashod_K_base_DP_5,
                Rashod_K_base_DP_E = _mdp.Rashod_K_base_DP_E_5,
                Proizvoditelnost_chug_base_DP = _mdp.Proizvoditelnost_chug_base_DP_5,
                Teor_t_base_DP = _mdp.Teor_t_base_DP_5,
                Teor_t_base_DPmin = _mdp.Teor_t_base_DPmin_5,
                Teor_t_base_DPmax = _mdp.Teor_t_base_DPmax_5,

                Proiz_chug_iz_PG_DP = _mdp.Proiz_chug_iz_PG_DP_5,
                Proiz_chug_uvel_K_DP = _mdp.Proiz_chug_uvel_K_DP_5,
                Iz_t_uvel_pg_DP = _mdp.Iz_t_uvel_pg_DP_5,
                
            });

            //Для ДП6
            modelDPs.Add(new ModelDP
            {
                xId = 6,
                Koef = (_mdp.Rashod_K_base_DP_E_6 * _mdp.Stoimoct_k - _mdp.Stoimoct_pg),
                KoefNerav1 = (-0.001 * _mdp.Rashod_K_base_DP_E_6),
                KoefNerav11 = (_mdp.Rashod_K_base_DP_6 + 0.001 * _mdp.Rashod_PG_base_DP_6 * _mdp.Rashod_K_base_DP_E_6),

                KoefNerav2 = _mdp.Proiz_chug_iz_PG_DP_6 - _mdp.Rashod_K_base_DP_E_6 * _mdp.Proiz_chug_uvel_K_DP_6,
                KoefNerav22 = -_mdp.Rashod_PG_base_DP_6 * _mdp.Proiz_chug_iz_PG_DP_6 + _mdp.Rashod_K_base_DP_E_6 * _mdp.Rashod_PG_base_DP_6 * _mdp.Proiz_chug_uvel_K_DP_6 + _mdp.Proizvoditelnost_chug_base_DP_6,


                KoefNerav3 = (_mdp.Teor_t_base_DPmin_6 + _mdp.Rashod_PG_base_DP_6 * _mdp.Iz_t_uvel_pg_DP_6 - _mdp.Teor_t_base_DP_6) / _mdp.Iz_t_uvel_pg_DP_6,
                KoefNerav33 = (_mdp.Teor_t_base_DPmax_6 + _mdp.Rashod_PG_base_DP_6 * _mdp.Iz_t_uvel_pg_DP_6 - _mdp.Teor_t_base_DP_6) / _mdp.Iz_t_uvel_pg_DP_6,


                Rashod_PG_base_DP = _mdp.Rashod_PG_base_DP_6,
                Rashod_PG_base_DPmin = _mdp.Rashod_PG_base_DPmin_6,
                Rashod_PG_base_DPmax = _mdp.Rashod_PG_base_DPmax_6,
                Rashod_K_base_DP = _mdp.Rashod_K_base_DP_6,
                Rashod_K_base_DP_E = _mdp.Rashod_K_base_DP_E_6,
                Proizvoditelnost_chug_base_DP = _mdp.Proizvoditelnost_chug_base_DP_6,
                Teor_t_base_DP = _mdp.Teor_t_base_DP_6,
                Teor_t_base_DPmin = _mdp.Teor_t_base_DPmin_6,
                Teor_t_base_DPmax = _mdp.Teor_t_base_DPmax_6,

                Proiz_chug_iz_PG_DP = _mdp.Proiz_chug_iz_PG_DP_6,
                Proiz_chug_uvel_K_DP = _mdp.Proiz_chug_uvel_K_DP_6,
                Iz_t_uvel_pg_DP = _mdp.Iz_t_uvel_pg_DP_6,
                
            });

            //Для ДП7
            modelDPs.Add(new ModelDP
            {
                xId = 7,
                Koef = (_mdp.Rashod_K_base_DP_E_7 * _mdp.Stoimoct_k - _mdp.Stoimoct_pg),
                KoefNerav1 = (-0.001 * _mdp.Rashod_K_base_DP_E_7),
                KoefNerav11 = (_mdp.Rashod_K_base_DP_7 + 0.001 * _mdp.Rashod_PG_base_DP_7 * _mdp.Rashod_K_base_DP_E_7),

                KoefNerav2 = _mdp.Proiz_chug_iz_PG_DP_7 - _mdp.Rashod_K_base_DP_E_7 * _mdp.Proiz_chug_uvel_K_DP_7,
                KoefNerav22 = -_mdp.Rashod_PG_base_DP_7 * _mdp.Proiz_chug_iz_PG_DP_7 + _mdp.Rashod_K_base_DP_E_7 * _mdp.Rashod_PG_base_DP_7 * _mdp.Proiz_chug_uvel_K_DP_7 + _mdp.Proizvoditelnost_chug_base_DP_7,


                KoefNerav3 = (_mdp.Teor_t_base_DPmin_7 + _mdp.Rashod_PG_base_DP_7 * _mdp.Iz_t_uvel_pg_DP_7 - _mdp.Teor_t_base_DP_7) / _mdp.Iz_t_uvel_pg_DP_7,
                KoefNerav33 = (_mdp.Teor_t_base_DPmax_7 + _mdp.Rashod_PG_base_DP_7 * _mdp.Iz_t_uvel_pg_DP_7 - _mdp.Teor_t_base_DP_7) / _mdp.Iz_t_uvel_pg_DP_7,


                Rashod_PG_base_DP = _mdp.Rashod_PG_base_DP_7,
                Rashod_PG_base_DPmin = _mdp.Rashod_PG_base_DPmin_7,
                Rashod_PG_base_DPmax = _mdp.Rashod_PG_base_DPmax_7,
                Rashod_K_base_DP = _mdp.Rashod_K_base_DP_7,
                Rashod_K_base_DP_E = _mdp.Rashod_K_base_DP_E_7,
                Proizvoditelnost_chug_base_DP = _mdp.Proizvoditelnost_chug_base_DP_7,
                Teor_t_base_DP = _mdp.Teor_t_base_DP_7,
                Teor_t_base_DPmin = _mdp.Teor_t_base_DPmin_7,
                Teor_t_base_DPmax = _mdp.Teor_t_base_DPmax_7,

                Proiz_chug_iz_PG_DP = _mdp.Proiz_chug_iz_PG_DP_7,
                Proiz_chug_uvel_K_DP = _mdp.Proiz_chug_uvel_K_DP_7,
                Iz_t_uvel_pg_DP = _mdp.Iz_t_uvel_pg_DP_7,
                
            });

            //Для ДП8
            modelDPs.Add(new ModelDP
            {
                xId = 8,
                Koef = (_mdp.Rashod_K_base_DP_E_8 * _mdp.Stoimoct_k - _mdp.Stoimoct_pg),
                KoefNerav1 = (-0.001 * _mdp.Rashod_K_base_DP_E_8),
                KoefNerav11 = (_mdp.Rashod_K_base_DP_8 + 0.001 * _mdp.Rashod_PG_base_DP_8 * _mdp.Rashod_K_base_DP_E_8),

                KoefNerav2 = _mdp.Proiz_chug_iz_PG_DP_8 - _mdp.Rashod_K_base_DP_E_8 * _mdp.Proiz_chug_uvel_K_DP_8,
                KoefNerav22 = -_mdp.Rashod_PG_base_DP_8 * _mdp.Proiz_chug_iz_PG_DP_8 + _mdp.Rashod_K_base_DP_E_8 * _mdp.Rashod_PG_base_DP_8 * _mdp.Proiz_chug_uvel_K_DP_8 + _mdp.Proizvoditelnost_chug_base_DP_8,


                KoefNerav3 = (_mdp.Teor_t_base_DPmin_8 + _mdp.Rashod_PG_base_DP_8 * _mdp.Iz_t_uvel_pg_DP_8 - _mdp.Teor_t_base_DP_8) / _mdp.Iz_t_uvel_pg_DP_8,
                KoefNerav33 = (_mdp.Teor_t_base_DPmax_8 + _mdp.Rashod_PG_base_DP_8 * _mdp.Iz_t_uvel_pg_DP_8 - _mdp.Teor_t_base_DP_8) / _mdp.Iz_t_uvel_pg_DP_8,


                Rashod_PG_base_DP = _mdp.Rashod_PG_base_DP_8,
                Rashod_PG_base_DPmin = _mdp.Rashod_PG_base_DPmin_8,
                Rashod_PG_base_DPmax = _mdp.Rashod_PG_base_DPmax_8,
                Rashod_K_base_DP = _mdp.Rashod_K_base_DP_8,
                Rashod_K_base_DP_E = _mdp.Rashod_K_base_DP_E_8,
                Proizvoditelnost_chug_base_DP = _mdp.Proizvoditelnost_chug_base_DP_8,
                Teor_t_base_DP = _mdp.Teor_t_base_DP_8,
                Teor_t_base_DPmin = _mdp.Teor_t_base_DPmin_8,
                Teor_t_base_DPmax = _mdp.Teor_t_base_DPmax_8,

                Proiz_chug_iz_PG_DP = _mdp.Proiz_chug_iz_PG_DP_8,
                Proiz_chug_uvel_K_DP = _mdp.Proiz_chug_uvel_K_DP_8,
                Iz_t_uvel_pg_DP = _mdp.Iz_t_uvel_pg_DP_8,
                
            });


            #endregion---


            SolverContext context = SolverContext.GetContext();
            context.ClearModel();
            Model model = context.CreateModel();
            Set users = new Set(Domain.Any, "users");


            Parameter Koef = new Parameter(Domain.Real, "Koef", users);
            Parameter KoefNerav1 = new Parameter(Domain.Real, "KoefNerav1", users);
            Parameter KoefNerav11 = new Parameter(Domain.Real, "KoefNerav11", users);
            Parameter KoefNerav2 = new Parameter(Domain.Real, "KoefNerav2", users);
            Parameter KoefNerav22 = new Parameter(Domain.Real, "KoefNerav22", users);
            Parameter KoefNerav3 = new Parameter(Domain.Real, "KoefNerav3", users);
            Parameter KoefNerav33 = new Parameter(Domain.Real, "KoefNerav33", users);


            Parameter Rashod_PG_base_DP = new Parameter(Domain.Real, "Rashod_PG_base_DP", users);
            Parameter Rashod_PG_base_DPmin = new Parameter(Domain.Real, "Rashod_PG_base_DPmin", users);
            Parameter Rashod_PG_base_DPmax = new Parameter(Domain.Real, "Rashod_PG_base_DPmax", users);
            Parameter Rashod_K_base_DP = new Parameter(Domain.Real, "Rashod_K_base_DP", users);
            Parameter Rashod_K_base_DP_E = new Parameter(Domain.Real, "Rashod_K_base_DP_E", users);
            Parameter Proizvoditelnost_chug_base_DP = new Parameter(Domain.Real, "Proizvoditelnost_chug_base_DP", users);
            Parameter Teor_t_base_DP = new Parameter(Domain.Real, "Teor_t_base_DP_1", users);
            Parameter Teor_t_base_DPmin = new Parameter(Domain.Real, "Teor_t_base_DPmin", users);
            Parameter Teor_t_base_DPmax = new Parameter(Domain.Real, "Teor_t_base_DPmax", users);


            Parameter Proiz_chug_iz_PG_DP = new Parameter(Domain.Real, "Proiz_chug_iz_PG_DP", users);
            Parameter Proiz_chug_uvel_K_DP = new Parameter(Domain.Real, "Proiz_chug_uvel_K_DP", users);
            Parameter Iz_t_uvel_pg_DP = new Parameter(Domain.Real, "Iz_t_uvel_pg_DP", users);


            Parameter Stoimoct_k = new Parameter(Domain.Real, "Stoimoct_k", users);
            Parameter Stoimoct_pg = new Parameter(Domain.Real, "Stoimoct_pg", users);
            Parameter Rezerf_rashod_pg = new Parameter(Domain.Real, "Rezerf_rashod_pg", users);
            Parameter Zapas_k = new Parameter(Domain.Real, "Zapas_k", users);
            Parameter Treb_proiz_chug = new Parameter(Domain.Real, "Treb_proiz_chug", users);

            
            Koef.SetBinding(modelDPs, "Koef", "xId");
            KoefNerav1.SetBinding(modelDPs, "KoefNerav1", "xId");
            KoefNerav11.SetBinding(modelDPs, "KoefNerav11", "xId");
            KoefNerav2.SetBinding(modelDPs, "KoefNerav2", "xId");
            KoefNerav22.SetBinding(modelDPs, "KoefNerav22", "xId");
            KoefNerav3.SetBinding(modelDPs, "KoefNerav3", "xId");
            KoefNerav33.SetBinding(modelDPs, "KoefNerav33", "xId");

            Rashod_PG_base_DP.SetBinding(modelDPs, "Rashod_PG_base_DP", "xId");
            Rashod_PG_base_DPmin.SetBinding(modelDPs, "Rashod_PG_base_DPmin", "xId");
            Rashod_PG_base_DPmax.SetBinding(modelDPs, "Rashod_PG_base_DPmax", "xId");
            Rashod_K_base_DP.SetBinding(modelDPs, "Rashod_K_base_DP", "xId");
            Rashod_K_base_DP_E.SetBinding(modelDPs, "Rashod_K_base_DP_E", "xId");
            Proizvoditelnost_chug_base_DP.SetBinding(modelDPs, "Proizvoditelnost_chug_base_DP", "xId");
            Teor_t_base_DP.SetBinding(modelDPs, "Teor_t_base_DP", "xId");
            Teor_t_base_DPmin.SetBinding(modelDPs, "Teor_t_base_DPmin", "xId");
            Teor_t_base_DPmax.SetBinding(modelDPs, "Teor_t_base_DPmax", "xId");


            Proiz_chug_iz_PG_DP.SetBinding(modelDPs, "Proiz_chug_iz_PG_DP", "xId");
            Proiz_chug_uvel_K_DP.SetBinding(modelDPs, "Proiz_chug_uvel_K_DP", "xId");
            Iz_t_uvel_pg_DP.SetBinding(modelDPs, "Iz_t_uvel_pg_DP", "xId");


            Stoimoct_k.SetBinding(modelDPs, "Stoimoct_k", "xId");
            Stoimoct_pg.SetBinding(modelDPs, "Stoimoct_pg", "xId");
            Rezerf_rashod_pg.SetBinding(modelDPs, "Rezerf_rashod_pg", "xId");
            Zapas_k.SetBinding(modelDPs, "Zapas_k", "xId");
            Treb_proiz_chug.SetBinding(modelDPs, "Treb_proiz_chug", "xId");

            
            model.AddParameters(

                Koef,
                KoefNerav1,
                KoefNerav11,
                KoefNerav2,
                KoefNerav22,
                KoefNerav3,
                KoefNerav33,


                Rashod_PG_base_DP,
                Rashod_PG_base_DPmin,
                Rashod_PG_base_DPmax,
                Rashod_K_base_DP,
                Rashod_K_base_DP_E,
                Proizvoditelnost_chug_base_DP,
                Teor_t_base_DP,
                Teor_t_base_DPmin,
                Teor_t_base_DPmax,


                Proiz_chug_iz_PG_DP,
                Proiz_chug_uvel_K_DP,
                Iz_t_uvel_pg_DP,


                Stoimoct_k,
                Stoimoct_pg,
                Rezerf_rashod_pg,
                Zapas_k,
                Treb_proiz_chug);


            Decision choose = new Decision(Domain.RealNonnegative, "choose", users);
            model.AddDecision(choose);


            model.AddGoal("Z", GoalKind.Maximize, Model.Sum(Model.ForEach(users, xId => choose[xId] * Koef[xId])));


            model.AddConstraint("Z1", Model.ForEach(users, xId => (Rashod_PG_base_DPmin[xId] <= choose[xId] <= Rashod_PG_base_DPmax[xId])));
            model.AddConstraint("Z2", Model.Sum(Model.ForEach(users, xId => choose[xId])) <= _mdp.Rezerf_rashod_pg);


            model.AddConstraint("Nerav1", Model.Sum(Model.ForEach(users, xId => choose[xId] * KoefNerav1[xId] + KoefNerav11[xId])) <= _mdp.Zapas_k);
            model.AddConstraint("Nerav2", Model.Sum(Model.ForEach(users, xId => choose[xId] * KoefNerav2[xId] + KoefNerav22[xId])) >= _mdp.Treb_proiz_chug);
            

            model.AddConstraint("Nerav3", Model.ForEach(users, xId => choose[xId]  <= KoefNerav3[xId]));
            model.AddConstraint("Nerav33", Model.ForEach(users, xId => choose[xId] >= KoefNerav33[xId]));


            try
            {
                Solution solution = context.Solve();
                Report report = solution.GetReport();

                String reportStr = "";

                for (int i = 0; i < modelDPs.Count; i++)
                {
                    reportStr += "Значение X" + (i + 1).ToString() + ": " + choose.GetDouble(modelDPs[i].xId) + "\n";
                }
                reportStr += "\n" + report.ToString();

                //MessageBox.Show(reportStr);
            }
            catch (Exception ex)
            {
                MessageBox.Show("При решении задачи оптимизации возникла исключительная ситуация.");
            }


            _mdp.DP1 = Math.Round(choose.GetDouble(modelDPs[0].xId),2);
            _mdp.DP2 = Math.Round(choose.GetDouble(modelDPs[1].xId), 2);
            _mdp.DP3 = Math.Round(choose.GetDouble(modelDPs[2].xId), 2);
            _mdp.DP4 = Math.Round(choose.GetDouble(modelDPs[3].xId), 2);
            _mdp.DP5 = Math.Round(choose.GetDouble(modelDPs[4].xId), 2);
            _mdp.DP6 = Math.Round(choose.GetDouble(modelDPs[5].xId), 2);
            _mdp.DP7 = Math.Round(choose.GetDouble(modelDPs[6].xId), 2);
            _mdp.DP8 = Math.Round(choose.GetDouble(modelDPs[7].xId), 2);

            
            txtDP1.Text = _mdp.DP1.ToString();
            txtDP2.Text = _mdp.DP2.ToString();
            txtDP3.Text = _mdp.DP3.ToString();
            txtDP4.Text = _mdp.DP4.ToString();
            txtDP5.Text = _mdp.DP5.ToString();
            txtDP6.Text = _mdp.DP6.ToString();
            txtDP7.Text = _mdp.DP7.ToString();
            txtDP8.Text = _mdp.DP8.ToString();


            double z = 0;
            for (int i = 0; i < 8; i++)
            {
                double a = choose.GetDouble(modelDPs[i].xId);
                double b = modelDPs[i].Koef;
                z += a * b;
                
            }
            txtZ.Text = z.ToString();
              
            //график
            this.chart1.Series[0].Points.AddXY("ДП1", txtRashod_PG_base_DP_1.Text);
            this.chart1.Series[0].Points.AddXY("ДП2", txtRashod_PG_base_DP_2.Text);
            this.chart1.Series[0].Points.AddXY("ДП3", txtRashod_PG_base_DP_3.Text);
            this.chart1.Series[0].Points.AddXY("ДП4", txtRashod_PG_base_DP_4.Text);
            this.chart1.Series[0].Points.AddXY("ДП5", txtRashod_PG_base_DP_5.Text);
            this.chart1.Series[0].Points.AddXY("ДП6", txtRashod_PG_base_DP_6.Text);
            this.chart1.Series[0].Points.AddXY("ДП7", txtRashod_PG_base_DP_7.Text);
            this.chart1.Series[0].Points.AddXY("ДП8", txtRashod_PG_base_DP_8.Text);

            this.chart1.Series[1].Points.AddXY("ДП1", choose.GetDouble(modelDPs[0].xId));
            this.chart1.Series[1].Points.AddXY("ДП2", choose.GetDouble(modelDPs[1].xId));
            this.chart1.Series[1].Points.AddXY("ДП3", choose.GetDouble(modelDPs[2].xId));
            this.chart1.Series[1].Points.AddXY("ДП4", choose.GetDouble(modelDPs[3].xId));
            this.chart1.Series[1].Points.AddXY("ДП5", choose.GetDouble(modelDPs[4].xId));
            this.chart1.Series[1].Points.AddXY("ДП6", choose.GetDouble(modelDPs[5].xId));
            this.chart1.Series[1].Points.AddXY("ДП7", choose.GetDouble(modelDPs[6].xId));
            this.chart1.Series[1].Points.AddXY("ДП8", choose.GetDouble(modelDPs[7].xId));

            

        }

        private void frMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //#region Ввод параметров
            //_mdp.Rashod_K_base_DP_1 (Double.Parse(txtt_d_.Text));
            //ct.SetV_do(Double.Parse(txtV_do.Text));
            //ct.SetP(Double.Parse(txtP.Text));
            //ct.SetP_np(Double.Parse(txtP_np.Text));
            //ct.Sett_nasp(Double.Parse(txtt_nasp.Text));
            //ct.SetP_atm(Double.Parse(txtP_atm.Text));
            //ct.SetT_dn(Double.Parse(txtT_dn.Text));
            //ct.SetT_dk(Double.Parse(txtT_dk.Text));
            //ct.Setdd(Double.Parse(txtdd.Text));
            //ct.Setl(Double.Parse(txtl.Text));
            //ct.SetGamma(Double.Parse(txtGamma.Text));
            //ct.SetAlpha_dk(Double.Parse(txtAlpha_dk.Text));
            //ct.SetEpsilon_st(Double.Parse(txtEpsilon_st.Text));
            //ct.SetKsi(Double.Parse(txtKsi.Text));
            //ct.SetCO2(Double.Parse(txtCO2.Text));
            //ct.SetH2O(Double.Parse(txtH2O.Text));
            //ct.SetO2(Double.Parse(txtO2.Text));

            //#endregion
            //XmlSerializer formatter = new XmlSerializer(typeof(RAS_PR_GAZ.ModelDP));
            //using (FileStream fs = new FileStream(Application.UserAppDataPath.ToString() + @"\\save.xml", FileMode.Create))
            //{
            //    formatter.Serialize(fs, _mdp);
            //    fs.Close();
            //}
        }

        private void lim_KeyPress(object sender, KeyPressEventArgs e)
        {
            //char number = e.KeyChar;
            //if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            //{
            //    e.Handled = true;
            //}
        }
    }
}
