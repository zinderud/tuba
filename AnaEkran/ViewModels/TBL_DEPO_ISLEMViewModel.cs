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
using System.Windows.Input;
using AnaEkran.Provider;
using System.Collections.ObjectModel;
using AnaEkran.Views.Raporlar;
using AnaEkran.Views.Raporlar.Depo;
using Zinde.Xpf.Printing;
using Zinde.XtraReports.UI;
using SimpleMvvmToolkit;
using AnaEkran.Models;
using ZindeMesajServisi.Messaging;
using AnaEkran.Mesaj;


#endregion

namespace AnaEkran.ViewModels
{
	public partial class TBL_DEPO_ISLEMViewModel  : ViewModelDetailBase<TBL_DEPO_ISLEMViewModel, TBL_DEPO_ISLEM_MODEL> 
    {
 	 public void Baslangic()
	 {


         DurumlarCollection = _durumListesi.DurumcObservableCollection;
	     DepoListesi();
	     UrunListesi();
	 }

        #region prop
     private ObservableCollection<TBL_DEPO_MODEL> _depolistesiCollection;
     public ObservableCollection<TBL_DEPO_MODEL> PropDepolistesiObservableCollection
     {
         get { return _depolistesiCollection; }
         set
         {
             _depolistesiCollection = value;
             NotifyPropertyChanged(m => m.PropDepolistesiObservableCollection);
         }
     }
     private ObservableCollection<TBL_URUN_MODEL> _propListeObservableCollection;
     public ObservableCollection<TBL_URUN_MODEL> PropListeObservableCollection
     {
         get { return _propListeObservableCollection; }
         set
         {
             _propListeObservableCollection = value;
             NotifyPropertyChanged(m => m.PropListeObservableCollection);
         }
     }
     #region durumlar
           //<zinderud:GridViewComboBoxColumn      ItemsSource="{Binding  DurumlarCollection}"  IsFilterable="True" IsReadOnly="False" 
           //    x:Name="DEPO_ONAYColumn" Width="Auto"  Header="DEPO ONAY" DataMemberBinding="{Binding DEPO_ONAY}" SelectedValueMemberPath="Durum" DisplayMemberPath="Durum"   
        //DurumlarCollection = _durumListesi.DurumcObservableCollection;
     DurumListesi _durumListesi = new DurumListesi();

     private ObservableCollection<Durumlar> _DurumlarCollection;

     public ObservableCollection<Durumlar> DurumlarCollection
     {
         get { return _DurumlarCollection; }
         set
         {
             _DurumlarCollection = value;
             NotifyPropertyChanged(m => m.DurumlarCollection);
         }
     }
     #endregion
   
     private TBL_URUN_MODEL _tblUrunModel;
     public TBL_URUN_MODEL SecilenTblUrunModel
     {
         get { return _tblUrunModel; }
         set
         {
             _tblUrunModel = value;
             NotifyPropertyChanged(m => m.SecilenTblUrunModel);
             this.model.TBL_URUN_ID = SecilenTblUrunModel.TBL_URUN_ID;
         }
     }
     private TBL_DEPO_MODEL _secilenTblDepoModel;
     public TBL_DEPO_MODEL SecilenTblDepoModel
     {
         get { return _secilenTblDepoModel; }
         set
         {
             _secilenTblDepoModel = value;
             NotifyPropertyChanged(m => m.SecilenTblDepoModel);
             this.Model.TBL_DEPO_ID = SecilenTblDepoModel.TBL_DEPO_ID;
         }
     }
        #endregion

	    public async void DepoListesi()
	    {
	        PropDepolistesiObservableCollection = await serviceAgent.Listele__TBL_DEPO_MODEL();
	    }
        public async void UrunListesi()
        {
            PropListeObservableCollection = await serviceAgent.Listele__TBL_URUN_MODEL();
        }
        #region urun depo stok ekle
        public async void UrunStokEkle(TBL_URUN_STOK_MODEL model)
        {
            try
            {
                //TBL_DEPO_ISLEM_MODEL model1 = new TBL_DEPO_ISLEM_MODEL();

                if (await serviceAgent.Ekle__TBL_URUN_STOK_MODEL(model))
                {
                    Listele();
                    Messenger.Default.Send<EkleTBL_URUN_STOKMesaj>(new EkleTBL_URUN_STOKMesaj() { MesajTBL_URUN_STOK = model, mesaj = "Eklendi" });

                }
                else
                {
                    Messenger.Default.Send<EkleTBL_URUN_STOKMesaj>(new EkleTBL_URUN_STOKMesaj() { MesajTBL_URUN_STOK = model, mesaj = "Eklendi bilinmeyen hata" });

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_URUN_STOKMesaj>(new HataTBL_URUN_STOKMesaj() { Hatamesaji = ex.ToString() });

            }

        }
        #endregion


	    public String depoadi(int? id)
	    {
	        try
	        {
	            return PropDepolistesiObservableCollection.Where(x => x.TBL_DEPO_ID == id).FirstOrDefault().DEPO_ADI;
	        }
	        catch (Exception)
	        {
	            
	             
	        }
	        return null;
	    }
        public String urunadi(int? id)
        {
            try
            {
                return PropListeObservableCollection.Where(x => x.TBL_URUN_ID == id).FirstOrDefault().URUN_ADI;
            }
            catch (Exception)
            {


            }
            return null;
        }
      
	    public void RaporListele()
	    {
            DataSet dataSet1 = new DataSet();
            dataSet1.DataSetName = "BankaListesiRapor";
            DataTable dataTable1 = new DataTable();

            dataSet1.Tables.Add(dataTable1);

            dataTable1.TableName = "Table";

            dataTable1.Columns.Add("ID", typeof(string));

            dataTable1.Columns.Add("DEPO ADI", typeof(string));

            dataTable1.Columns.Add("URUN_ADI", typeof(string));

            dataTable1.Columns.Add("ISLEM_ADI", typeof(string));

            dataTable1.Columns.Add("URUN_MIKTAR", typeof(string));

            dataTable1.Columns.Add("ONAY", typeof(string));

            dataTable1.Columns.Add("ACIKLAMA", typeof(string));

            dataTable1.Columns.Add("YEDEK", typeof(string));
	        foreach (var k in Propdepo_ýslemListe)
	        {
	            dataTable1.Rows.Add(new Object[]
	            {

	                k.TBL_DEPO_ISLEM_ID,

	             depoadi(k.TBL_DEPO_ID)   ,

	               urunadi( k.TBL_URUN_ID),

	                k.DEPO_ISLEM_ADI,

	                k.URUN_MIKTAR,

	                k.DEPO_ONAY,

	                k.ACIKLAMA,

	                k.YEDEK,


	            });
	        }
            Rapordepo_Islem report = new Rapordepo_Islem();
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

	 
report.xrTableCell5.DataBindings.Add("Text", null, dataTable1.Columns[4].Caption);
report.xrLabel5.Text = dataTable1.Columns[4].ColumnName;

	 
report.xrTableCell6.DataBindings.Add("Text", null, dataTable1.Columns[5].Caption);
report.xrLabel6.Text = dataTable1.Columns[5].ColumnName;

	 
//report.xrTableCell7.DataBindings.Add("Text", null, dataTable1.Columns[6].Caption);
//report.xrLabel7.Text = dataTable1.Columns[6].ColumnName;

	 
//report.xrTableCell8.DataBindings.Add("Text", null, dataTable1.Columns[7].Caption);
//report.xrLabel8.Text = dataTable1.Columns[7].ColumnName;

RaporSayfasi pencere = new RaporSayfasi();


pencere.Preview.Model = new XtraReportPreviewModel(report);
report.CreateDocument(true);



pencere.ShowDialog();

 
 //report.ShowPreviewDialog();

	    }
    }
}
