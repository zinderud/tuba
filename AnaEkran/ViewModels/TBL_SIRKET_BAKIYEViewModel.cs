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
using System.Windows.Forms;
using System.Windows.Input;
using AnaEkran.Provider;
using System.Collections.ObjectModel;
using AnaEkran.Views.Raporlar;
using AnaEkran.Views.Raporlar.Sirket;
using Zinde.Xpf.Printing;
using Zinde.XtraReports.UI;
using SimpleMvvmToolkit;
using AnaEkran.Models;
using ZindeMesajServisi.Messaging;
using AnaEkran.Mesaj;


#endregion

namespace AnaEkran.ViewModels
{
	public partial class TBL_SIRKET_BAKIYEViewModel  : ViewModelDetailBase<TBL_SIRKET_BAKIYEViewModel, TBL_SIRKET_BAKIYE_MODEL> 
    {
	  
		
	 public void Baslangic()
     {
         TBL_SIRKETListesi();
	     TBL_PARA_TIPIListesi();
	     TBL_FISListesi();
     }
     #region TBL_SIRKET
     private ObservableCollection<TBL_SIRKET_MODEL> _TBL_SIRKETlistesiCollection;
     public ObservableCollection<TBL_SIRKET_MODEL> PropTBL_SIRKETlistesiCollection
     {
         get { return _TBL_SIRKETlistesiCollection; }
         set
         {
             _TBL_SIRKETlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_SIRKETlistesiCollection);
         }
     }
     private TBL_SIRKET_MODEL _TBL_SIRKET_MODELModel;
     public TBL_SIRKET_MODEL SecilenTBL_SIRKET_MODEL
     {
         get { return _TBL_SIRKET_MODELModel; }
         set
         {
             _TBL_SIRKET_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_SIRKET_MODEL);
             this.Model.TBL_SIRKET_ID = SecilenTBL_SIRKET_MODEL.TBL_SIRKET_ID;
         }
     }
     public async void TBL_SIRKETListesi()
     {
         PropTBL_SIRKETlistesiCollection = await serviceAgent.Listele__TBL_SIRKET_MODEL();
     }
     #endregion
     #region TBL_PARA_TIPI
     private ObservableCollection<TBL_PARA_TIPI_MODEL> _TBL_PARA_TIPIlistesiCollection;
     public ObservableCollection<TBL_PARA_TIPI_MODEL> PropTBL_PARA_TIPIlistesiCollection
     {
         get { return _TBL_PARA_TIPIlistesiCollection; }
         set
         {
             _TBL_PARA_TIPIlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_PARA_TIPIlistesiCollection);
         }
     }
     private TBL_PARA_TIPI_MODEL _TBL_PARA_TIPI_MODELModel;
     public TBL_PARA_TIPI_MODEL SecilenTBL_PARA_TIPI_MODEL
     {
         get { return _TBL_PARA_TIPI_MODELModel; }
         set
         {
             _TBL_PARA_TIPI_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_PARA_TIPI_MODEL);
             this.Model.TBL_PARA_TIPI_ID = SecilenTBL_PARA_TIPI_MODEL.TBL_PARA_TIPI_ID;
         }
     }
     public async void TBL_PARA_TIPIListesi()
     {
         PropTBL_PARA_TIPIlistesiCollection = await serviceAgent.Listele__TBL_PARA_TIPI_MODEL();
     }
     #endregion
     #region TBL_FIS
     private ObservableCollection<TBL_FIS_MODEL> _TBL_FISlistesiCollection;
     public ObservableCollection<TBL_FIS_MODEL> PropTBL_FISlistesiCollection
     {
         get { return _TBL_FISlistesiCollection; }
         set
         {
             _TBL_FISlistesiCollection = value;
             NotifyPropertyChanged(m => m.PropTBL_FISlistesiCollection);
         }
     }
     private TBL_FIS_MODEL _TBL_FIS_MODELModel;
     public TBL_FIS_MODEL SecilenTBL_FIS_MODEL
     {
         get { return _TBL_FIS_MODELModel; }
         set
         {
             _TBL_FIS_MODELModel = value;
             NotifyPropertyChanged(m => m.SecilenTBL_FIS_MODEL);
             this.Model.TBL_FIS_ID = SecilenTBL_FIS_MODEL.TBL_FIS_ID;
         }
     }
     public async void TBL_FISListesi()
     {
         PropTBL_FISlistesiCollection = await serviceAgent.Listele__TBL_FIS_MODEL();
     }
     #endregion
     #region SirketPara iliþkisi

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
     public async void SirketParaIliskisiListele()
     {
         _grupToplamModels = new ObservableCollection<GrupToplamModel>();
                  var model1 = Propsýrket_bakýyeListe = await serviceAgent.Listele__TBL_SIRKET_BAKIYE_MODEL();

                  //var grubid = from detay in model1
                  //             group detay by detay.TBL_SIRKET_ID
                  //                 into Grup
                  //                 select new
                  //                 {
                  //                     toplam = Grup.Sum(k => Convert.ToInt32(k.TUTAR)),
                  //                     dene = Grup.Key,
                  //                     TBL_SIRKET_ID = Grup.Key.ToString()
                  //                 };

                  //foreach (var k in grubid)
                  //{
                  //    var deneme = (from c in model1
                  //                  where c.TBL_SIRKET_ID == Convert.ToInt32(k.TBL_SIRKET_ID)
                  //                  group k by new { c.TBL_SIRKET_ID, c.TBL_FIS_ID }
                  //                      into sonucliste
                  //                      select new { den = sonucliste.Key.TBL_FIS_ID }).ToList();


                  //}

                      
         var listeler = from detay in model1
                        group detay by detay.TBL_SIRKET_ID
                            into Grup
                            select new
                            {
                                toplam = Grup.Sum(k => Convert.ToInt32(k.TUTAR)),
                                dene=Grup.Key,
                                TBL_SIRKET_ID = Grup.Key.ToString()
                            };
         foreach (var k in listeler)
         {
             _grupToplamModels.Add(new GrupToplamModel() { Toplam = k.toplam.ToString(), Gruplanan = k.TBL_SIRKET_ID });
         }
         GrupToplamModel = _grupToplamModels;
     }
     #endregion

     //Sirketadi(k.TBL_SIRKET_ID),
     public String Sirketadi(int? id)
     {
         try
         {
             return PropTBL_SIRKETlistesiCollection.Where(x => x.TBL_SIRKET_ID == id).FirstOrDefault().SIRKET_ADI;
         }
         catch (Exception)
         {


         }
         return null;
     }

     // pARAadi( k.TBL_PARA_TIPI_ID),
     public String pARAadi(int? id)
     {
         try
         {
             return PropTBL_PARA_TIPIlistesiCollection.Where(x => x.TBL_PARA_TIPI_ID == id).FirstOrDefault().PARA_TIPI_ADI;

         }
         catch (Exception)
         {


         }
         return null;
     }

	    public void RaporSirketParaListele()
	    {
            try
            {
                DataSet dataSet1 = new DataSet();
                dataSet1.DataSetName = "RaporSirketParaListele";
                DataTable dataTable1 = new DataTable();

                dataSet1.Tables.Add(dataTable1);

                dataTable1.TableName = "Table";

                dataTable1.Columns.Add("Þirket Adý", typeof(string));

                dataTable1.Columns.Add("Toplam", typeof(string));


                foreach (var k in GrupToplamModel)
                {
                    dataTable1.Rows.Add(new Object[]
	            {
	               Sirketadi(Convert.ToInt32(k.Gruplanan))   , k.Toplam
	            });
                }
                RaporSirketParaListele report = new RaporSirketParaListele();
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
	    public void RaporSirketBakiyeListele()
	    {
	        try
	        {
                DataSet dataSet1 = new DataSet();
                dataSet1.DataSetName = "Sirket BakiyeListesiRapor";
                DataTable dataTable1 = new DataTable();

                dataSet1.Tables.Add(dataTable1);

                dataTable1.TableName = "Table";

                dataTable1.Columns.Add("ID", typeof(string));

                dataTable1.Columns.Add("SIRKET ADI", typeof(string));

                dataTable1.Columns.Add("PARA_TIPI", typeof(string));

                dataTable1.Columns.Add("FIS ID", typeof(string));

                dataTable1.Columns.Add("KUR", typeof(string));

                dataTable1.Columns.Add("TARIH", typeof(string));

                dataTable1.Columns.Add("TUTAR", typeof(string));

                dataTable1.Columns.Add("ACIKLAMA", typeof(string));

                dataTable1.Columns.Add("YEDEK", typeof(string));
	            foreach (var k in Propsýrket_bakýyeListe)
	            {
	                dataTable1.Rows.Add(new Object[]
	                {

	                    k.TBL_SIRKET_BAKIYE_ID,

	                      Sirketadi(k.TBL_SIRKET_ID),

	                pARAadi( k.TBL_PARA_TIPI_ID),

	                    k.TBL_FIS_ID,

	                    k.KUR,

	                    k.TARIH,

	                    k.TUTAR,

	                    k.ACIKLAMA,

	                    k.YEDEK,


	                });
	            }
                //public partial class TBL_SIRKET_BAKIYE_MODEL  :ModelBase<TBL_SIRKET_BAKIYE_MODEL>
 RaporSirketBakiye report = new  RaporSirketBakiye();
report.DataSource = dataSet1;
report.DataMember = dataTable1.TableName;
	 
//_tBL_SIRKET_BAKIYE_ID
report.xrTableCell1.DataBindings.Add("Text", null, dataTable1.Columns[0].Caption);
report.xrLabel1.Text = dataTable1.Columns[0].ColumnName;

	 
//_tBL_SIRKET_ID
report.xrTableCell2.DataBindings.Add("Text", null, dataTable1.Columns[1].Caption);
report.xrLabel2.Text = dataTable1.Columns[1].ColumnName;

	 
//_tBL_PARA_TIPI_ID
report.xrTableCell3.DataBindings.Add("Text", null, dataTable1.Columns[2].Caption);
report.xrLabel3.Text = dataTable1.Columns[2].ColumnName;

	 
//_tBL_FIS_ID
report.xrTableCell4.DataBindings.Add("Text", null, dataTable1.Columns[3].Caption);
report.xrLabel4.Text = dataTable1.Columns[3].ColumnName;

	 
//_kUR
report.xrTableCell5.DataBindings.Add("Text", null, dataTable1.Columns[4].Caption);
report.xrLabel5.Text = dataTable1.Columns[4].ColumnName;

	 
//_tARIH
report.xrTableCell6.DataBindings.Add("Text", null, dataTable1.Columns[5].Caption);
report.xrLabel6.Text = dataTable1.Columns[5].ColumnName;

	 
//_tUTAR
report.xrTableCell7.DataBindings.Add("Text", null, dataTable1.Columns[6].Caption);
report.xrLabel7.Text = dataTable1.Columns[6].ColumnName;

	 
////_aCIKLAMA
//report.xrTableCell8.DataBindings.Add("Text", null, dataTable1.Columns[7].Caption);
//report.xrLabel8.Text = dataTable1.Columns[7].ColumnName;

	 
////_yEDEK
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

	            MessageBox.Show("Hata");;
	        }
	    }
	}
}
