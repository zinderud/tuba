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
	public partial class TBL_URUN_TIPIViewModel  : ViewModelDetailBase< TBL_URUN_TIPIViewModel,TBL_URUN_TIPI_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_URUN_TIPIViewModel () { }
TBL_URUN_TIPI_MODEL model=new TBL_URUN_TIPI_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_URUN_TIPIViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_URUN_TIPI  tablosu modeli
        /// </summary>
     
        private TBL_URUN_TIPI_MODEL _Propurun_tıpı;

        public TBL_URUN_TIPI_MODEL Propurun_tıpı
        {
            get { return _Propurun_tıpı; }
            set { _Propurun_tıpı = value;
                NotifyPropertyChanged(m=>m.Propurun_tıpı);
                } 
        }
		 /// <summary>
        ///TBL_URUN_TIPI  tablosu Secilen
        /// </summary>
     
        private TBL_URUN_TIPI_MODEL _Propurun_tıpıSecilen;

        public TBL_URUN_TIPI_MODEL Propurun_tıpıSecilen
        {
            get { return _Propurun_tıpıSecilen; }
            set { _Propurun_tıpıSecilen = value;
                NotifyPropertyChanged(m=>m.Propurun_tıpıSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_URUN_TIPI  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_URUN_TIPI_MODEL> _Propurun_tıpıListe;

        public ObservableCollection<TBL_URUN_TIPI_MODEL> Propurun_tıpıListe
        {
            get { return _Propurun_tıpıListe; }
            set { _Propurun_tıpıListe = value; 
                NotifyPropertyChanged(m=>m.Propurun_tıpıListe);
                }
        }
         /// <summary>
        ///TBL_URUN_TIPI  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_URUN_TIPI_MODEL> _Propurun_tıpıListeSecilen;

        public ObservableCollection<TBL_URUN_TIPI_MODEL> Propurun_tıpıListeSecilen
        {
            get { return _Propurun_tıpıListeSecilen; }
            set { _Propurun_tıpıListeSecilen = value; 
                NotifyPropertyChanged(m=>m.Propurun_tıpıListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_URUN_TIPI_MODEL model1 = new TBL_URUN_TIPI_MODEL();
              //  model1 = Propurun_tıpıSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_URUN_TIPI_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_URUN_TIPIMesaj>(new EkleTBL_URUN_TIPIMesaj() { MesajTBL_URUN_TIPI= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_URUN_TIPIMesaj>(new EkleTBL_URUN_TIPIMesaj() { MesajTBL_URUN_TIPI= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_URUN_TIPIMesaj>(new HataTBL_URUN_TIPIMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_URUN_TIPI_MODEL model1 = new TBL_URUN_TIPI_MODEL();
                model1 = Propurun_tıpıSecilen;
                if (await serviceAgent.Sil__TBL_URUN_TIPI_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_URUN_TIPIMesaj>(new SilTBL_URUN_TIPIMesaj() { MesajTBL_URUN_TIPI= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_URUN_TIPIMesaj>(new SilTBL_URUN_TIPIMesaj() { MesajTBL_URUN_TIPI= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_URUN_TIPIMesaj>(new HataTBL_URUN_TIPIMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_URUN_TIPI_MODEL model1 = new TBL_URUN_TIPI_MODEL();
                model1 = Propurun_tıpıSecilen;
            if (await serviceAgent.Degistir__TBL_URUN_TIPI_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_URUN_TIPIMesaj>(new DegistirTBL_URUN_TIPIMesaj() { MesajTBL_URUN_TIPI= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_URUN_TIPIMesaj>(new DegistirTBL_URUN_TIPIMesaj() { MesajTBL_URUN_TIPI= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_URUN_TIPIMesaj>(new HataTBL_URUN_TIPIMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                Propurun_tıpıListe = await serviceAgent.Listele__TBL_URUN_TIPI_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_URUN_TIPIMesaj>(new HataTBL_URUN_TIPIMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propurun_tıpı = await serviceAgent.Bul_TBL_URUN_TIPI_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_URUN_TIPIMesaj>(new HataTBL_URUN_TIPIMesaj() { Hatamesaji = ex.ToString()});


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
