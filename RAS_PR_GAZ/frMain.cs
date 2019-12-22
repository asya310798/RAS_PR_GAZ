using Microsoft.SolverFoundation.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            
            if (
            #region---
            (txtRashod_PG_base_DP_1.Text == "") ||
            (txtRashod_PG_base_DPmin_1.Text == "") ||
            (txtRashod_PG_base_DPmax_1.Text == "") ||
            (txtRashod_K_base_DP_1.Text == "") ||
            (txtRashod_K_base_DP_E_1.Text == "") ||
            (txtProizvoditelnost_chug_base_DP_1.Text == "") ||
            (txtTeor_t_base_DP_1.Text == "") ||
            (txtTeor_t_base_DPmin_1.Text == "") ||
            (txtTeor_t_base_DPmax_1.Text == "") ||
            (txtProiz_chug_iz_PG_DP_1.Text == "") ||
            (txtProiz_chug_uvel_K_DP_1.Text == "") ||
            (txtIz_t_uvel_pg_DP_1.Text == "") ||

            (txtRashod_PG_base_DP_2.Text == "") ||
            (txtRashod_PG_base_DPmin_2.Text == "") ||
            (txtRashod_PG_base_DPmax_2.Text == "") ||
            (txtRashod_K_base_DP_2.Text == "") ||
            (txtRashod_K_base_DP_E_2.Text == "") ||
            (txtProizvoditelnost_chug_base_DP_2.Text == "") ||
            (txtTeor_t_base_DP_2.Text == "") ||
            (txtTeor_t_base_DPmin_2.Text == "") ||
            (txtTeor_t_base_DPmax_2.Text == "") ||
            (txtProiz_chug_iz_PG_DP_2.Text == "") ||
            (txtProiz_chug_uvel_K_DP_2.Text == "") ||
            (txtIz_t_uvel_pg_DP_2.Text == "") ||

            (txtRashod_PG_base_DP_3.Text == "") ||
            (txtRashod_PG_base_DPmin_3.Text == "") ||
            (txtRashod_PG_base_DPmax_3.Text == "") ||
            (txtRashod_K_base_DP_3.Text == "") ||
            (txtRashod_K_base_DP_E_3.Text == "") ||
            (txtProizvoditelnost_chug_base_DP_3.Text == "") ||
            (txtTeor_t_base_DP_3.Text == "") ||
            (txtTeor_t_base_DPmin_3.Text == "") ||
            (txtTeor_t_base_DPmax_3.Text == "") ||
            (txtProiz_chug_iz_PG_DP_3.Text == "") ||
            (txtProiz_chug_uvel_K_DP_3.Text == "") ||
            (txtIz_t_uvel_pg_DP_3.Text == "") ||

            (txtRashod_PG_base_DP_4.Text == "") ||
            (txtRashod_PG_base_DPmin_4.Text == "") ||
            (txtRashod_PG_base_DPmax_4.Text == "") ||
            (txtRashod_K_base_DP_4.Text == "") ||
            (txtRashod_K_base_DP_E_4.Text == "") ||
            (txtProizvoditelnost_chug_base_DP_4.Text == "") ||
            (txtTeor_t_base_DP_4.Text == "") ||
            (txtTeor_t_base_DPmin_4.Text == "") ||
            (txtTeor_t_base_DPmax_4.Text == "") ||
            (txtProiz_chug_iz_PG_DP_4.Text == "") ||
            (txtProiz_chug_uvel_K_DP_4.Text == "") ||
            (txtIz_t_uvel_pg_DP_4.Text == "") ||

            (txtRashod_PG_base_DP_5.Text == "") ||
            (txtRashod_PG_base_DPmin_5.Text == "") ||
            (txtRashod_PG_base_DPmax_5.Text == "") ||
            (txtRashod_K_base_DP_5.Text == "") ||
            (txtRashod_K_base_DP_E_5.Text == "") ||
            (txtProizvoditelnost_chug_base_DP_5.Text == "") ||
            (txtTeor_t_base_DP_5.Text == "") ||
            (txtTeor_t_base_DPmin_5.Text == "") ||
            (txtTeor_t_base_DPmax_5.Text == "") ||
            (txtProiz_chug_iz_PG_DP_5.Text == "") ||
            (txtProiz_chug_uvel_K_DP_5.Text == "") ||
            (txtIz_t_uvel_pg_DP_5.Text == "") ||

            (txtRashod_PG_base_DP_6.Text == "") ||
            (txtRashod_PG_base_DPmin_6.Text == "") ||
            (txtRashod_PG_base_DPmax_6.Text == "") ||
            (txtRashod_K_base_DP_6.Text == "") ||
            (txtRashod_K_base_DP_E_6.Text == "") ||
            (txtProizvoditelnost_chug_base_DP_6.Text == "") ||
            (txtTeor_t_base_DP_6.Text == "") ||
            (txtTeor_t_base_DPmin_6.Text == "") ||
            (txtTeor_t_base_DPmax_6.Text == "") ||
            (txtProiz_chug_iz_PG_DP_6.Text == "") ||
            (txtProiz_chug_uvel_K_DP_6.Text == "") ||
            (txtIz_t_uvel_pg_DP_6.Text == "") ||

            (txtRashod_PG_base_DP_7.Text == "") ||
            (txtRashod_PG_base_DPmin_7.Text == "") ||
            (txtRashod_PG_base_DPmax_7.Text == "") ||
            (txtRashod_K_base_DP_7.Text == "") ||
            (txtRashod_K_base_DP_E_7.Text == "") ||
            (txtProizvoditelnost_chug_base_DP_7.Text == "") ||
            (txtTeor_t_base_DP_7.Text == "") ||
            (txtTeor_t_base_DPmin_7.Text == "") ||
            (txtTeor_t_base_DPmax_7.Text == "") ||
            (txtProiz_chug_iz_PG_DP_7.Text == "") ||
            (txtProiz_chug_uvel_K_DP_7.Text == "") ||
            (txtIz_t_uvel_pg_DP_7.Text == "") ||

            (txtRashod_PG_base_DP_8.Text == "") ||
            (txtRashod_PG_base_DPmin_8.Text == "") ||
            (txtRashod_PG_base_DPmax_8.Text == "") ||
            (txtRashod_K_base_DP_8.Text == "") ||
            (txtRashod_K_base_DP_E_8.Text == "") ||
            (txtProizvoditelnost_chug_base_DP_8.Text == "") ||
            (txtTeor_t_base_DP_8.Text == "") ||
            (txtTeor_t_base_DPmin_8.Text == "") ||
            (txtTeor_t_base_DPmax_8.Text == "") ||
            (txtProiz_chug_iz_PG_DP_8.Text == "") ||
            (txtProiz_chug_uvel_K_DP_8.Text == "") ||
            (txtIz_t_uvel_pg_DP_8.Text == ""))
            #endregion---
            {
                tPGraph.Parent = null;
                MessageBox.Show("Не все поля заполнены!", "Ошибка");
                return;
            }
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
                Rashod_PG_base_DPmin = _mdp.Rashod_PG_base_DPmin_1,
                Rashod_PG_base_DPmax = _mdp.Rashod_PG_base_DPmax_1,
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
                Rashod_PG_base_DPmin = _mdp.Rashod_PG_base_DPmin_2,
                Rashod_PG_base_DPmax = _mdp.Rashod_PG_base_DPmax_2
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
                Rashod_PG_base_DPmin = _mdp.Rashod_PG_base_DPmin_3,
                Rashod_PG_base_DPmax = _mdp.Rashod_PG_base_DPmax_3
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
                Rashod_PG_base_DPmin = _mdp.Rashod_PG_base_DPmin_4,
                Rashod_PG_base_DPmax = _mdp.Rashod_PG_base_DPmax_4
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
                Rashod_PG_base_DPmin = _mdp.Rashod_PG_base_DPmin_5,
                Rashod_PG_base_DPmax = _mdp.Rashod_PG_base_DPmax_5
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
                Rashod_PG_base_DPmin = _mdp.Rashod_PG_base_DPmin_6,
                Rashod_PG_base_DPmax = _mdp.Rashod_PG_base_DPmax_6

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
                Rashod_PG_base_DPmin = _mdp.Rashod_PG_base_DPmin_7,
                Rashod_PG_base_DPmax = _mdp.Rashod_PG_base_DPmax_7

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
                Rashod_PG_base_DPmin = _mdp.Rashod_PG_base_DPmin_8,
                Rashod_PG_base_DPmax = _mdp.Rashod_PG_base_DPmax_8

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
            Parameter Rashod_PG_base_DPmin = new Parameter(Domain.Real, "Rashod_PG_base_DPmin", users);
            Parameter Rashod_PG_base_DPmax = new Parameter(Domain.Real, "Rashod_PG_base_DPmax", users);
            
            Koef.SetBinding(modelDPs, "Koef", "xId");
            KoefNerav1.SetBinding(modelDPs, "KoefNerav1", "xId");
            KoefNerav11.SetBinding(modelDPs, "KoefNerav11", "xId");
            KoefNerav2.SetBinding(modelDPs, "KoefNerav2", "xId");
            KoefNerav22.SetBinding(modelDPs, "KoefNerav22", "xId");
            KoefNerav3.SetBinding(modelDPs, "KoefNerav3", "xId");
            KoefNerav33.SetBinding(modelDPs, "KoefNerav33", "xId");
            Rashod_PG_base_DPmin.SetBinding(modelDPs, "Rashod_PG_base_DPmin", "xId");
            Rashod_PG_base_DPmax.SetBinding(modelDPs, "Rashod_PG_base_DPmax", "xId");
            
            model.AddParameters(
                Koef,
                KoefNerav1,
                KoefNerav11,
                KoefNerav2,
                KoefNerav22,
                KoefNerav3,
                KoefNerav33,
                Rashod_PG_base_DPmin,
                Rashod_PG_base_DPmax
                );
            
            Decision choose = new Decision(Domain.RealNonnegative, "choose", users);
            model.AddDecision(choose);

            model.AddGoal("Z", GoalKind.Maximize, Model.Sum(Model.ForEach(users, xId => choose[xId] * Koef[xId])));

            model.AddConstraint("Z1", Model.ForEach(users, xId => (Rashod_PG_base_DPmin[xId] <= choose[xId] <= Rashod_PG_base_DPmax[xId])));
            model.AddConstraint("Z2", Model.Sum(Model.ForEach(users, xId => choose[xId])) <= _mdp.Rezerf_rashod_pg);
            model.AddConstraint("Nerav1", Model.Sum(Model.ForEach(users, xId => choose[xId] * KoefNerav1[xId] + KoefNerav11[xId])) <= _mdp.Zapas_k);
            model.AddConstraint("Nerav2", Model.Sum(Model.ForEach(users, xId => choose[xId] * KoefNerav2[xId] + KoefNerav22[xId])) >= _mdp.Treb_proiz_chug);
            model.AddConstraint("Nerav3", Model.ForEach(users, xId => KoefNerav33[xId] <= choose[xId]  <= KoefNerav3[xId]));
            
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
            
            _mdp.DP1 = Math.Round(choose.GetDouble(modelDPs[0].xId), 2);
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

        private void lim_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0,1,2,3,4,5,6,7,8,9,\b]");
        }

        private void limIZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"[0,1,2,3,4,5,6,7,8,9,--,\b]");
        }
        
        private void Clear_TextChanged(object sender, EventArgs e)
        {
            tPGraph.Parent = null;
            txtDP1.Text = "";
            txtDP2.Text = "";
            txtDP3.Text = "";
            txtDP4.Text = "";
            txtDP5.Text = "";
            txtDP6.Text = "";
            txtDP7.Text = "";
            txtDP8.Text = "";
            txtZ.Text = "";
        }   
    }       
}           
            
            
            
            