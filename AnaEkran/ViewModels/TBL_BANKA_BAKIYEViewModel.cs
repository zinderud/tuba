//===================================================================================
// Sio
// Sio
//===================================================================================

#region
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using AnaEkran.Provider;
using System.Collections.ObjectModel;
using AnaEkran.Views.Raporlar;
using AnaEkran.Views.Raporlar.Banka;
using Zinde.Xpf.Printing;
using Zinde.XtraReports.UI;
using SimpleMvvmToolkit;
using AnaEkran.Models;
using ZindeMesajServisi.Messaging;
using AnaEkran.Mesaj;


#endregion

namespace AnaEkran.ViewModels
{
	public partial class TBL_BANKA_BAKIYEViewModel  : ViewModelDetailBase<TBL_BANKA_BAKIYEViewModel, TBL_BANKA_BAKIYE_MODEL> 
    {



        public void Baslangic()
        {
            ParaTipiGetir();
            BankaIdGetir();
            FisIdGetir();
        }
        #region prop
        private ObservableCollection<TBL_PARA_TIPI_MODEL> _paratipi;
        public ObservableCollection<TBL_PARA_TIPI_MODEL> PrpParaTipiModel
        {
            get { return _paratipi; }
            set
            {
                _paratipi = value;
                NotifyPropertyChanged(m => m.PrpParaTipiModel);
            }
        }
        private ObservableCollection<TBL_BANKA_MODEL> _bankaView;
        public ObservableCollection<TBL_BANKA_MODEL> PrpBankaList
        {
            get { return _bankaView; }
            set
            {
                _bankaView = value;
                NotifyPropertyChanged(m => m.PrpBankaList);
            }
        }

        private ObservableCollection<TBL_FIS_MODEL> _fisModels;
        public ObservableCollection<TBL_FIS_MODEL> PropTblFisModels
        {
            get { return _fisModels; }
            set
            {
                _fisModels = value;
                NotifyPropertyChanged(m => m.PropTblFisModels);
            }
        }
        private TBL_FIS_MODEL _secilenFisModel;
        public TBL_FIS_MODEL SecilenTblFisModel
        {
            get { return _secilenFisModel; }
            set
            {
                _secilenFisModel = value;
                NotifyPropertyChanged(m => m.SecilenTblFisModel);
                this.Model.TBL_FIS_ID = SecilenTblFisModel.TBL_FIS_ID;
            }
        }

        private TBL_BANKA_MODEL _secilenBankaModel;
        public TBL_BANKA_MODEL SecilenTblBankaModel
        {
            get { return _secilenBankaModel; }
            set
            {
                _secilenBankaModel = value;
                NotifyPropertyChanged(m => m.SecilenTblBankaModel);
                this.Model.TBL_BANKA_ID = SecilenTblBankaModel.TBL_BANKA_ID;
              
                this.model.TBL_PARA_TIPI_ID = SecilenTblBankaModel.TBL_PARA_TIPI_ID;
                ParaTipiAdiGetir(SecilenTblBankaModel.TBL_PARA_TIPI_ID);
            }
        }


        private TBL_PARA_TIPI_MODEL _secilParaTipiModel;
        public TBL_PARA_TIPI_MODEL SecilenTblParaTipiModel
        {
            get { return _secilParaTipiModel; }
            set
            {

                _secilParaTipiModel = value;
                NotifyPropertyChanged(m => m.SecilenTblParaTipiModel);
                PropParaTipiAdi = SecilenTblParaTipiModel.PARA_TIPI_ADI;
                this.Model.TBL_PARA_TIPI_ID = SecilenTblParaTipiModel.TBL_PARA_TIPI_ID;
            }
        }

        private string _paraadi;
        public string PropParaTipiAdi
        {
            get { return _paraadi; }
            set
            {
                _paraadi = value;
                NotifyPropertyChanged(m => m.PropParaTipiAdi);
            }
        }
        #endregion


        public async void ParaTipiGetir()
        {
            PrpParaTipiModel = await serviceAgent.Listele__TBL_PARA_TIPI_MODEL();
        }
        public async void BankaIdGetir()
        {
            PrpBankaList = await serviceAgent.Listele__TBL_BANKA_MODEL();
        }
        public async void FisIdGetir()
        {
            PropTblFisModels = await serviceAgent.Listele__TBL_FIS_MODEL();
        }
        public async void ParaTipiAdiGetir(int? id)
        {
            var liste = new ObservableCollection<TBL_PARA_TIPI_MODEL>();
            liste = PrpParaTipiModel;

            var sonuc = (from k in liste where k.TBL_PARA_TIPI_ID == id select k).First();

            PropParaTipiAdi = sonuc.PARA_TIPI_ADI;
        }




        #region BAnkaPara iliþkisi

        private ObservableCollection<GrupToplamModel> _GrupToplamModel;
        public ObservableCollection<GrupToplamModel> GrupToplamModel
        {
            get { return _GrupToplamModel; }
            set
            {
                _GrupToplamModel = value;
                NotifyPropertyChanged(m => m.GrupToplamModel);
            }
        }

        ObservableCollection<GrupToplamModel> _grupToplamModels;
        public async void BankaParaIliskisiListele()
        {
            _grupToplamModels = new ObservableCollection<GrupToplamModel>();
            //var deneme = from k in Propurun_stokListe
            //    group k by k.TBL_URUN_ID
            //    into g
            //    select new {urunid=g,adet=


            //        g.Key};
            PrpBankaList = await serviceAgent.Listele__TBL_BANKA_MODEL();
            var model1 = Propbanka_bakýyeListe = await serviceAgent.Listele__TBL_BANKA_BAKIYE_MODEL();

            var listeler = from detay in model1
                           group detay by detay.TBL_BANKA_ID
                               into Grup
                               select new
                               {
                                   toplam = Grup.Sum(k => Convert.ToInt32(k.TUTAR)),

                                   TBL_BANKA_ID = Grup.Key.ToString()
                               };
            foreach (var k in listeler)
            {
                _grupToplamModels.Add(new GrupToplamModel() { Toplam = k.toplam.ToString(), Gruplanan = k.TBL_BANKA_ID });
            }
            GrupToplamModel = _grupToplamModels;
        }
        #endregion

	    public string Bankaadi(int? id)
	    {
	        try
	        {
                return PrpBankaList.Where(x => x.TBL_BANKA_ID == id).SingleOrDefault().BANKA_ADI;
	        }
	        catch (Exception)
	        {
	          
	        }
	        return null;

	    }
        public string ParaAdi(int? id)
        {
            try
            {
                return PrpParaTipiModel.Where(x => x.TBL_PARA_TIPI_ID == id).SingleOrDefault().PARA_TIPI_ADI;
            }
            catch (Exception)
            {
                
               
            }
            return null;

        }
	    public void RaporListele()
	    {
	        try
	        {
                DataSet dataSet1 = new DataSet();
                dataSet1.DataSetName = "BankaListesiRapor";
                DataTable dataTable1 = new DataTable();

                dataSet1.Tables.Add(dataTable1);

                dataTable1.TableName = "Table";

                dataTable1.Columns.Add("ID", typeof(string));

                dataTable1.Columns.Add("BANKA ID", typeof(string));

                dataTable1.Columns.Add("PARA TIPI", typeof(string));

                dataTable1.Columns.Add("TBLFIS ID", typeof(string));

                dataTable1.Columns.Add("KUR", typeof(string));

                dataTable1.Columns.Add("TARIH", typeof(string));

                dataTable1.Columns.Add("TUTAR", typeof(string));

                dataTable1.Columns.Add("ACIKLAMA", typeof(string));

                dataTable1.Columns.Add("YEDEK", typeof(string));
                foreach (var k in Propbanka_bakýyeListe)
                {
                    dataTable1.Rows.Add(new Object[]
	            {
	                k.TBL_BANKA_BAKIYE_ID, Bankaadi(k.TBL_BANKA_ID), ParaAdi(k.TBL_PARA_TIPI_ID), k.TBL_FIS_ID, k.KUR, k.TARIH, k.TUTAR,
	                k.ACIKLAMA, k.YEDEK
	            });
                }
                Raporbanka_bakýye report = new Raporbanka_bakýye();
                report.DataSource = dataSet1;
                report.DataMember = dataTable1.TableName;

                report.xrTableCell1.DataBindings.Add("Text", null, dataTable1.Columns[0].Caption);
                report.xrLabel1.Text = dataTable1.Columns[0].ColumnName;


                report.xrTableCell2.DataBindings.Add("Text", null, dataTable1.Columns[1].Caption);
                report.xrLabel2.Text = dataTable1.Columns[1].ColumnName;


                report.xrTableCell3.DataBindings.Add("Text", null, dataTable1.Columns[2].Caption);
                report.xrLabel3.Text = dataTable1.Columns[2].ColumnName;


                report.xrTableCell4.DataBindings.Add("Text", null, dataTable1.Columns[3].Caption);
                report.xrLabel4.Text = dataTable1.Columns[3].ColumnName;


                report.xrTableCell5.DataBindings.Add("Text", null, dataTable1.Columns[6].Caption);
                report.xrLabel5.Text = dataTable1.Columns[6].ColumnName;


                report.xrTableCell6.DataBindings.Add("Text", null, dataTable1.Columns[5].Caption);
                report.xrLabel6.Text = dataTable1.Columns[5].ColumnName;


                //report.xrTableCell7.DataBindings.Add("Text", null, dataTable1.Columns[6].Caption);
                //report.xrLabel7.Text = dataTable1.Columns[6].ColumnName;


                //report.xrTableCell8.DataBindings.Add("Text", null, dataTable1.Columns[7].Caption);
                //report.xrLabel8.Text = dataTable1.Columns[7].ColumnName;


                //report.xrTableCell9.DataBindings.Add("Text", null, dataTable1.Columns[8].Caption);
                //report.xrLabel9.Text = dataTable1.Columns[8].ColumnName;

                RaporSayfasi pencere = new RaporSayfasi();


                pencere.Preview.Model = new XtraReportPreviewModel(report);
                report.CreateDocument(true);



                pencere.ShowDialog();


                //report.ShowPreviewDialog();
	        }
	        catch (Exception)
	        {

	            MessageBox.Show("Hata Oluþtu");
	        }
            
            
	    }
        public void RaporBankaParaListele()
        {
            try
            {
                DataSet dataSet1 = new DataSet();
                dataSet1.DataSetName = "RaporBankaParaListele";
                DataTable dataTable1 = new DataTable();

                dataSet1.Tables.Add(dataTable1);

                dataTable1.TableName = "Table";

                dataTable1.Columns.Add("Banka Adý", typeof(string));

                dataTable1.Columns.Add("Toplam", typeof(string));


                foreach (var k in GrupToplamModel)
                {
                    dataTable1.Rows.Add(new Object[]
	            {
	               Bankaadi(Convert.ToInt32(k.Gruplanan))   , k.Toplam
	            });
                }
                RaporBankaParaListele report = new RaporBankaParaListele();
                report.DataSource = dataSet1;
                report.DataMember = dataTable1.TableName;

                report.xrTableCell1.DataBindings.Add("Text", null, dataTable1.Columns[0].Caption);
                report.xrLabel1.Text = dataTable1.Columns[0].ColumnName;


                report.xrTableCell2.DataBindings.Add("Text", null, dataTable1.Columns[1].Caption);
                report.xrLabel2.Text = dataTable1.Columns[1].ColumnName;


                //report.xrTableCell3.DataBindings.Add("Text", null, dataTable1.Columns[2].Caption);
                //report.xrLabel3.Text = dataTable1.Columns[2].ColumnName;


                //report.xrTableCell4.DataBindings.Add("Text", null, dataTable1.Columns[3].Caption);
                //report.xrLabel4.Text = dataTable1.Columns[3].ColumnName;


                //report.xrTableCell5.DataBindings.Add("Text", null, dataTable1.Columns[6].Caption);
                //report.xrLabel5.Text = dataTable1.Columns[6].ColumnName;


                //report.xrTableCell6.DataBindings.Add("Text", null, dataTable1.Columns[5].Caption);
                //report.xrLabel6.Text = dataTable1.Columns[5].ColumnName;


                //report.xrTableCell7.DataBindings.Add("Text", null, dataTable1.Columns[6].Caption);
                //report.xrLabel7.Text = dataTable1.Columns[6].ColumnName;


                //report.xrTableCell8.DataBindings.Add("Text", null, dataTable1.Columns[7].Caption);
                //report.xrLabel8.Text = dataTable1.Columns[7].ColumnName;


                //report.xrTableCell9.DataBindings.Add("Text", null, dataTable1.Columns[8].Caption);
                //report.xrLabel9.Text = dataTable1.Columns[8].ColumnName;

                RaporSayfasi pencere = new RaporSayfasi();


                pencere.Preview.Model = new XtraReportPreviewModel(report);
                report.CreateDocument(true);



                pencere.ShowDialog();


                //report.ShowPreviewDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluþtu");
            }


        }
	}
}
