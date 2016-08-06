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
	public partial class TBL_PARA_TIPIViewModel  : ViewModelDetailBase< TBL_PARA_TIPIViewModel,TBL_PARA_TIPI_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_PARA_TIPIViewModel () { }
TBL_PARA_TIPI_MODEL model=new TBL_PARA_TIPI_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_PARA_TIPIViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_PARA_TIPI  tablosu modeli
        /// </summary>
     
        private TBL_PARA_TIPI_MODEL _Proppara_tıpı;

        public TBL_PARA_TIPI_MODEL Proppara_tıpı
        {
            get { return _Proppara_tıpı; }
            set { _Proppara_tıpı = value;
                NotifyPropertyChanged(m=>m.Proppara_tıpı);
                } 
        }
		 /// <summary>
        ///TBL_PARA_TIPI  tablosu Secilen
        /// </summary>
     
        private TBL_PARA_TIPI_MODEL _Proppara_tıpıSecilen;

        public TBL_PARA_TIPI_MODEL Proppara_tıpıSecilen
        {
            get { return _Proppara_tıpıSecilen; }
            set { _Proppara_tıpıSecilen = value;
                NotifyPropertyChanged(m=>m.Proppara_tıpıSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_PARA_TIPI  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_PARA_TIPI_MODEL> _Proppara_tıpıListe;

        public ObservableCollection<TBL_PARA_TIPI_MODEL> Proppara_tıpıListe
        {
            get { return _Proppara_tıpıListe; }
            set { _Proppara_tıpıListe = value; 
                NotifyPropertyChanged(m=>m.Proppara_tıpıListe);
                }
        }
         /// <summary>
        ///TBL_PARA_TIPI  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_PARA_TIPI_MODEL> _Proppara_tıpıListeSecilen;

        public ObservableCollection<TBL_PARA_TIPI_MODEL> Proppara_tıpıListeSecilen
        {
            get { return _Proppara_tıpıListeSecilen; }
            set { _Proppara_tıpıListeSecilen = value; 
                NotifyPropertyChanged(m=>m.Proppara_tıpıListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_PARA_TIPI_MODEL model1 = new TBL_PARA_TIPI_MODEL();
              //  model1 = Proppara_tıpıSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_PARA_TIPI_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_PARA_TIPIMesaj>(new EkleTBL_PARA_TIPIMesaj() { MesajTBL_PARA_TIPI= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_PARA_TIPIMesaj>(new EkleTBL_PARA_TIPIMesaj() { MesajTBL_PARA_TIPI= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_PARA_TIPIMesaj>(new HataTBL_PARA_TIPIMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_PARA_TIPI_MODEL model1 = new TBL_PARA_TIPI_MODEL();
                model1 = Proppara_tıpıSecilen;
                if (await serviceAgent.Sil__TBL_PARA_TIPI_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_PARA_TIPIMesaj>(new SilTBL_PARA_TIPIMesaj() { MesajTBL_PARA_TIPI= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_PARA_TIPIMesaj>(new SilTBL_PARA_TIPIMesaj() { MesajTBL_PARA_TIPI= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_PARA_TIPIMesaj>(new HataTBL_PARA_TIPIMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_PARA_TIPI_MODEL model1 = new TBL_PARA_TIPI_MODEL();
                model1 = Proppara_tıpıSecilen;
            if (await serviceAgent.Degistir__TBL_PARA_TIPI_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_PARA_TIPIMesaj>(new DegistirTBL_PARA_TIPIMesaj() { MesajTBL_PARA_TIPI= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_PARA_TIPIMesaj>(new DegistirTBL_PARA_TIPIMesaj() { MesajTBL_PARA_TIPI= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_PARA_TIPIMesaj>(new HataTBL_PARA_TIPIMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                Proppara_tıpıListe = await serviceAgent.Listele__TBL_PARA_TIPI_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_PARA_TIPIMesaj>(new HataTBL_PARA_TIPIMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Proppara_tıpı = await serviceAgent.Bul_TBL_PARA_TIPI_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_PARA_TIPIMesaj>(new HataTBL_PARA_TIPIMesaj() { Hatamesaji = ex.ToString()});


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
