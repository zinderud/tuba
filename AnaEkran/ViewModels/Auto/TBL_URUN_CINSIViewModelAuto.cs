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
	public partial class TBL_URUN_CINSIViewModel  : ViewModelDetailBase< TBL_URUN_CINSIViewModel,TBL_URUN_CINSI_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_URUN_CINSIViewModel () { }
TBL_URUN_CINSI_MODEL model=new TBL_URUN_CINSI_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_URUN_CINSIViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_URUN_CINSI  tablosu modeli
        /// </summary>
     
        private TBL_URUN_CINSI_MODEL _Propurun_cınsı;

        public TBL_URUN_CINSI_MODEL Propurun_cınsı
        {
            get { return _Propurun_cınsı; }
            set { _Propurun_cınsı = value;
                NotifyPropertyChanged(m=>m.Propurun_cınsı);
                } 
        }
		 /// <summary>
        ///TBL_URUN_CINSI  tablosu Secilen
        /// </summary>
     
        private TBL_URUN_CINSI_MODEL _Propurun_cınsıSecilen;

        public TBL_URUN_CINSI_MODEL Propurun_cınsıSecilen
        {
            get { return _Propurun_cınsıSecilen; }
            set { _Propurun_cınsıSecilen = value;
                NotifyPropertyChanged(m=>m.Propurun_cınsıSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_URUN_CINSI  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_URUN_CINSI_MODEL> _Propurun_cınsıListe;

        public ObservableCollection<TBL_URUN_CINSI_MODEL> Propurun_cınsıListe
        {
            get { return _Propurun_cınsıListe; }
            set { _Propurun_cınsıListe = value; 
                NotifyPropertyChanged(m=>m.Propurun_cınsıListe);
                }
        }
         /// <summary>
        ///TBL_URUN_CINSI  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_URUN_CINSI_MODEL> _Propurun_cınsıListeSecilen;

        public ObservableCollection<TBL_URUN_CINSI_MODEL> Propurun_cınsıListeSecilen
        {
            get { return _Propurun_cınsıListeSecilen; }
            set { _Propurun_cınsıListeSecilen = value; 
                NotifyPropertyChanged(m=>m.Propurun_cınsıListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_URUN_CINSI_MODEL model1 = new TBL_URUN_CINSI_MODEL();
              //  model1 = Propurun_cınsıSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_URUN_CINSI_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_URUN_CINSIMesaj>(new EkleTBL_URUN_CINSIMesaj() { MesajTBL_URUN_CINSI= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_URUN_CINSIMesaj>(new EkleTBL_URUN_CINSIMesaj() { MesajTBL_URUN_CINSI= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_URUN_CINSIMesaj>(new HataTBL_URUN_CINSIMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_URUN_CINSI_MODEL model1 = new TBL_URUN_CINSI_MODEL();
                model1 = Propurun_cınsıSecilen;
                if (await serviceAgent.Sil__TBL_URUN_CINSI_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_URUN_CINSIMesaj>(new SilTBL_URUN_CINSIMesaj() { MesajTBL_URUN_CINSI= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_URUN_CINSIMesaj>(new SilTBL_URUN_CINSIMesaj() { MesajTBL_URUN_CINSI= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_URUN_CINSIMesaj>(new HataTBL_URUN_CINSIMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_URUN_CINSI_MODEL model1 = new TBL_URUN_CINSI_MODEL();
                model1 = Propurun_cınsıSecilen;
            if (await serviceAgent.Degistir__TBL_URUN_CINSI_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_URUN_CINSIMesaj>(new DegistirTBL_URUN_CINSIMesaj() { MesajTBL_URUN_CINSI= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_URUN_CINSIMesaj>(new DegistirTBL_URUN_CINSIMesaj() { MesajTBL_URUN_CINSI= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_URUN_CINSIMesaj>(new HataTBL_URUN_CINSIMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                Propurun_cınsıListe = await serviceAgent.Listele__TBL_URUN_CINSI_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_URUN_CINSIMesaj>(new HataTBL_URUN_CINSIMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propurun_cınsı = await serviceAgent.Bul_TBL_URUN_CINSI_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_URUN_CINSIMesaj>(new HataTBL_URUN_CINSIMesaj() { Hatamesaji = ex.ToString()});


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
