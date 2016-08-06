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
using System.Windows.Markup;
using AnaEkran.Annotations;
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
using Zinderud.Windows.Persistence.Core;

#endregion

namespace AnaEkran.ViewModels
{
	public partial class TBL_BANKAViewModel  : ViewModelDetailBase<TBL_BANKAViewModel, TBL_BANKA_MODEL> 
    {
	  
		
	 public void Baslangic()
	 {
	     ParaTipiGetir();
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

     private TBL_PARA_TIPI_MODEL _secilParaTipiModel;
     public TBL_PARA_TIPI_MODEL SecilenTblParaTipiModel
     {
         get { return _secilParaTipiModel; }
         set
         {
            
             _secilParaTipiModel = value;
             NotifyPropertyChanged(m => m.SecilenTblParaTipiModel);
           
             this.Model.TBL_PARA_TIPI_ID = SecilenTblParaTipiModel.TBL_PARA_TIPI_ID;
         }
     }
     #endregion

	    public async void ParaTipiGetir()
	    {
	        PrpParaTipiModel = await serviceAgent.Listele__TBL_PARA_TIPI_MODEL();
	    }


	    public void Rapor()
	    {

            DataSet dataSet1 = new DataSet();
            dataSet1.DataSetName = "BankaListesiRapor";
            DataTable dataTable1 = new DataTable();

            dataSet1.Tables.Add(dataTable1);

            dataTable1.TableName = "Table";
            dataTable1.Columns.Add("BANKA_ADI", typeof(string));
            dataTable1.Columns.Add("BANKA_IBAN_NO", typeof(string));
            dataTable1.Columns.Add("BANKA_SUBE_ADI", typeof(string));
            dataTable1.Columns.Add("BANKA_TELEFON_1", typeof(string));
            dataTable1.Columns.Add("BANKA_MAIL", typeof(string));

             
            foreach (var k in PropbankaListe)
            {
                dataTable1.Rows.Add(new Object[] { k.BANKA_ADI.ToString(), k.BANKA_IBAN_NO.ToString(), k.BANKA_SUBE_ADI ,k.BANKA_TELEFON_1,k.BANKA_MAIL});
            }

            BankaListesiRapor report = new BankaListesiRapor();

            report.DataSource = dataSet1;
            report.DataMember = dataTable1.TableName;
            //cell.Text = dc.ColumnName;
            report.xrTableCell1.DataBindings.Add("Text", null, dataTable1.Columns[0].Caption);
            report.xrTableCell2.DataBindings.Add("Text", null, dataTable1.Columns[1].Caption);
            report.xrTableCell3.DataBindings.Add("Text", null, dataTable1.Columns[2].Caption);
            report.xrTableCell4.DataBindings.Add("Text", null, dataTable1.Columns[3].Caption);
            report.xrTableCell5.DataBindings.Add("Text", null, dataTable1.Columns[4].Caption);


            report.xrLabel1.Text = dataTable1.Columns[0].ColumnName;
            RaporSayfasi pencere = new RaporSayfasi();


            pencere.Preview.Model = new XtraReportPreviewModel(report);
            report.CreateDocument(true);



            pencere.ShowDialog();
            //report.ShowPreviewDialog();
	    }
         
	}
}
