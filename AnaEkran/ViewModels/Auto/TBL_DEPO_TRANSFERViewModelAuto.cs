//===================================================================================
// Sio
// Sio
//===================================================================================

#region
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using AnaEkran.Provider;
using System.Collections.ObjectModel;
using SimpleMvvmToolkit;
using AnaEkran.Models;
using ZindeMesajServisi.Messaging;
using AnaEkran.Mesaj;


#endregion

namespace AnaEkran.ViewModels
{
	public partial class TBL_DEPO_TRANSFERViewModel  : ViewModelDetailBase< TBL_DEPO_TRANSFERViewModel,TBL_DEPO_TRANSFER_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_DEPO_TRANSFERViewModel () { }
TBL_DEPO_TRANSFER_MODEL model=new TBL_DEPO_TRANSFER_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_DEPO_TRANSFERViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_DEPO_TRANSFER  tablosu modeli
        /// </summary>
     
        private TBL_DEPO_TRANSFER_MODEL _Propdepo_transfer;

        public TBL_DEPO_TRANSFER_MODEL Propdepo_transfer
        {
            get { return _Propdepo_transfer; }
            set { _Propdepo_transfer = value;
                NotifyPropertyChanged(m=>m.Propdepo_transfer);
                } 
        }
		 /// <summary>
        ///TBL_DEPO_TRANSFER  tablosu Secilen
        /// </summary>
     
        private TBL_DEPO_TRANSFER_MODEL _Propdepo_transferSecilen;

        public TBL_DEPO_TRANSFER_MODEL Propdepo_transferSecilen
        {
            get { return _Propdepo_transferSecilen; }
            set { _Propdepo_transferSecilen = value;
                NotifyPropertyChanged(m=>m.Propdepo_transferSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_DEPO_TRANSFER  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_DEPO_TRANSFER_MODEL> _Propdepo_transferListe;

        public ObservableCollection<TBL_DEPO_TRANSFER_MODEL> Propdepo_transferListe
        {
            get { return _Propdepo_transferListe; }
            set { _Propdepo_transferListe = value; 
                NotifyPropertyChanged(m=>m.Propdepo_transferListe);
                }
        }
         /// <summary>
        ///TBL_DEPO_TRANSFER  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_DEPO_TRANSFER_MODEL> _Propdepo_transferListeSecilen;

        public ObservableCollection<TBL_DEPO_TRANSFER_MODEL> Propdepo_transferListeSecilen
        {
            get { return _Propdepo_transferListeSecilen; }
            set { _Propdepo_transferListeSecilen = value; 
                NotifyPropertyChanged(m=>m.Propdepo_transferListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_DEPO_TRANSFER_MODEL model1 = new TBL_DEPO_TRANSFER_MODEL();
              //  model1 = Propdepo_transferSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_DEPO_TRANSFER_MODEL(model1))
                {
                    DepoTransferUrunEtkisi();
                       Listele();
                    Messenger.Default.Send<EkleTBL_DEPO_TRANSFERMesaj>(new EkleTBL_DEPO_TRANSFERMesaj() { MesajTBL_DEPO_TRANSFER= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_DEPO_TRANSFERMesaj>(new EkleTBL_DEPO_TRANSFERMesaj() { MesajTBL_DEPO_TRANSFER= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_DEPO_TRANSFERMesaj>(new HataTBL_DEPO_TRANSFERMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_DEPO_TRANSFER_MODEL model1 = new TBL_DEPO_TRANSFER_MODEL();
                model1 = Propdepo_transferSecilen;
                if (await serviceAgent.Sil__TBL_DEPO_TRANSFER_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_DEPO_TRANSFERMesaj>(new SilTBL_DEPO_TRANSFERMesaj() { MesajTBL_DEPO_TRANSFER= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_DEPO_TRANSFERMesaj>(new SilTBL_DEPO_TRANSFERMesaj() { MesajTBL_DEPO_TRANSFER= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_DEPO_TRANSFERMesaj>(new HataTBL_DEPO_TRANSFERMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_DEPO_TRANSFER_MODEL model1 = new TBL_DEPO_TRANSFER_MODEL();
                model1 = Propdepo_transferSecilen;
            if (await serviceAgent.Degistir__TBL_DEPO_TRANSFER_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_DEPO_TRANSFERMesaj>(new DegistirTBL_DEPO_TRANSFERMesaj() { MesajTBL_DEPO_TRANSFER= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_DEPO_TRANSFERMesaj>(new DegistirTBL_DEPO_TRANSFERMesaj() { MesajTBL_DEPO_TRANSFER= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_DEPO_TRANSFERMesaj>(new HataTBL_DEPO_TRANSFERMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                Propdepo_transferListe = await serviceAgent.Listele__TBL_DEPO_TRANSFER_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_DEPO_TRANSFERMesaj>(new HataTBL_DEPO_TRANSFERMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propdepo_transfer = await serviceAgent.Bul_TBL_DEPO_TRANSFER_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_DEPO_TRANSFERMesaj>(new HataTBL_DEPO_TRANSFERMesaj() { Hatamesaji = ex.ToString()});


             }
        }
        
        #endregion
		#region komut
	 public ICommand EkleCommand
        {
            get
            {
                return new DelegateCommand(Ekle);
            }
        }
		 public ICommand SiCommand
        {
            get
            {
                return new DelegateCommand(Sil);
            }
        }
		 public ICommand DegistirCommand
        {
            get
            {
                return new DelegateCommand(Degistir);
            }
        }
		 public ICommand ListeleCommand
        {
            get
            {
                return new DelegateCommand(Listele);
            }
        }
		 public ICommand BulCommand
        {
            get
            {
                return new DelegateCommand<int>(Bul);
            }
        }
	   #endregion

        
         
	}
}
