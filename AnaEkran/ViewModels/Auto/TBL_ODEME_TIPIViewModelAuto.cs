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
	public partial class TBL_ODEME_TIPIViewModel  : ViewModelDetailBase< TBL_ODEME_TIPIViewModel,TBL_ODEME_TIPI_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_ODEME_TIPIViewModel () { }
TBL_ODEME_TIPI_MODEL model=new TBL_ODEME_TIPI_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_ODEME_TIPIViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_ODEME_TIPI  tablosu modeli
        /// </summary>
     
        private TBL_ODEME_TIPI_MODEL _Propodeme_tıpı;

        public TBL_ODEME_TIPI_MODEL Propodeme_tıpı
        {
            get { return _Propodeme_tıpı; }
            set { _Propodeme_tıpı = value;
                NotifyPropertyChanged(m=>m.Propodeme_tıpı);
                } 
        }
		 /// <summary>
        ///TBL_ODEME_TIPI  tablosu Secilen
        /// </summary>
     
        private TBL_ODEME_TIPI_MODEL _Propodeme_tıpıSecilen;

        public TBL_ODEME_TIPI_MODEL Propodeme_tıpıSecilen
        {
            get { return _Propodeme_tıpıSecilen; }
            set { _Propodeme_tıpıSecilen = value;
                NotifyPropertyChanged(m=>m.Propodeme_tıpıSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_ODEME_TIPI  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_ODEME_TIPI_MODEL> _Propodeme_tıpıListe;

        public ObservableCollection<TBL_ODEME_TIPI_MODEL> Propodeme_tıpıListe
        {
            get { return _Propodeme_tıpıListe; }
            set { _Propodeme_tıpıListe = value; 
                NotifyPropertyChanged(m=>m.Propodeme_tıpıListe);
                }
        }
         /// <summary>
        ///TBL_ODEME_TIPI  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_ODEME_TIPI_MODEL> _Propodeme_tıpıListeSecilen;

        public ObservableCollection<TBL_ODEME_TIPI_MODEL> Propodeme_tıpıListeSecilen
        {
            get { return _Propodeme_tıpıListeSecilen; }
            set { _Propodeme_tıpıListeSecilen = value; 
                NotifyPropertyChanged(m=>m.Propodeme_tıpıListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_ODEME_TIPI_MODEL model1 = new TBL_ODEME_TIPI_MODEL();
              //  model1 = Propodeme_tıpıSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_ODEME_TIPI_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_ODEME_TIPIMesaj>(new EkleTBL_ODEME_TIPIMesaj() { MesajTBL_ODEME_TIPI= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_ODEME_TIPIMesaj>(new EkleTBL_ODEME_TIPIMesaj() { MesajTBL_ODEME_TIPI= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_ODEME_TIPIMesaj>(new HataTBL_ODEME_TIPIMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_ODEME_TIPI_MODEL model1 = new TBL_ODEME_TIPI_MODEL();
                model1 = Propodeme_tıpıSecilen;
                if (await serviceAgent.Sil__TBL_ODEME_TIPI_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_ODEME_TIPIMesaj>(new SilTBL_ODEME_TIPIMesaj() { MesajTBL_ODEME_TIPI= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_ODEME_TIPIMesaj>(new SilTBL_ODEME_TIPIMesaj() { MesajTBL_ODEME_TIPI= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_ODEME_TIPIMesaj>(new HataTBL_ODEME_TIPIMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_ODEME_TIPI_MODEL model1 = new TBL_ODEME_TIPI_MODEL();
                model1 = Propodeme_tıpıSecilen;
            if (await serviceAgent.Degistir__TBL_ODEME_TIPI_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_ODEME_TIPIMesaj>(new DegistirTBL_ODEME_TIPIMesaj() { MesajTBL_ODEME_TIPI= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_ODEME_TIPIMesaj>(new DegistirTBL_ODEME_TIPIMesaj() { MesajTBL_ODEME_TIPI= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_ODEME_TIPIMesaj>(new HataTBL_ODEME_TIPIMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                Propodeme_tıpıListe = await serviceAgent.Listele__TBL_ODEME_TIPI_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_ODEME_TIPIMesaj>(new HataTBL_ODEME_TIPIMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propodeme_tıpı = await serviceAgent.Bul_TBL_ODEME_TIPI_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_ODEME_TIPIMesaj>(new HataTBL_ODEME_TIPIMesaj() { Hatamesaji = ex.ToString()});


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
