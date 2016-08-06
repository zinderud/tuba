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
	public partial class TBL_SIRKET_SINIFViewModel  : ViewModelDetailBase< TBL_SIRKET_SINIFViewModel,TBL_SIRKET_SINIF_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_SIRKET_SINIFViewModel () { }
TBL_SIRKET_SINIF_MODEL model=new TBL_SIRKET_SINIF_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_SIRKET_SINIFViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_SIRKET_SINIF  tablosu modeli
        /// </summary>
     
        private TBL_SIRKET_SINIF_MODEL _Propsırket_sınıf;

        public TBL_SIRKET_SINIF_MODEL Propsırket_sınıf
        {
            get { return _Propsırket_sınıf; }
            set { _Propsırket_sınıf = value;
                NotifyPropertyChanged(m=>m.Propsırket_sınıf);
                } 
        }
		 /// <summary>
        ///TBL_SIRKET_SINIF  tablosu Secilen
        /// </summary>
     
        private TBL_SIRKET_SINIF_MODEL _Propsırket_sınıfSecilen;

        public TBL_SIRKET_SINIF_MODEL Propsırket_sınıfSecilen
        {
            get { return _Propsırket_sınıfSecilen; }
            set { _Propsırket_sınıfSecilen = value;
                NotifyPropertyChanged(m=>m.Propsırket_sınıfSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_SIRKET_SINIF  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_SIRKET_SINIF_MODEL> _Propsırket_sınıfListe;

        public ObservableCollection<TBL_SIRKET_SINIF_MODEL> Propsırket_sınıfListe
        {
            get { return _Propsırket_sınıfListe; }
            set { _Propsırket_sınıfListe = value; 
                NotifyPropertyChanged(m=>m.Propsırket_sınıfListe);
                }
        }
         /// <summary>
        ///TBL_SIRKET_SINIF  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_SIRKET_SINIF_MODEL> _Propsırket_sınıfListeSecilen;

        public ObservableCollection<TBL_SIRKET_SINIF_MODEL> Propsırket_sınıfListeSecilen
        {
            get { return _Propsırket_sınıfListeSecilen; }
            set { _Propsırket_sınıfListeSecilen = value; 
                NotifyPropertyChanged(m=>m.Propsırket_sınıfListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_SIRKET_SINIF_MODEL model1 = new TBL_SIRKET_SINIF_MODEL();
              //  model1 = Propsırket_sınıfSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_SIRKET_SINIF_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_SIRKET_SINIFMesaj>(new EkleTBL_SIRKET_SINIFMesaj() { MesajTBL_SIRKET_SINIF= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_SIRKET_SINIFMesaj>(new EkleTBL_SIRKET_SINIFMesaj() { MesajTBL_SIRKET_SINIF= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_SIRKET_SINIFMesaj>(new HataTBL_SIRKET_SINIFMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_SIRKET_SINIF_MODEL model1 = new TBL_SIRKET_SINIF_MODEL();
                model1 = Propsırket_sınıfSecilen;
                if (await serviceAgent.Sil__TBL_SIRKET_SINIF_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_SIRKET_SINIFMesaj>(new SilTBL_SIRKET_SINIFMesaj() { MesajTBL_SIRKET_SINIF= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_SIRKET_SINIFMesaj>(new SilTBL_SIRKET_SINIFMesaj() { MesajTBL_SIRKET_SINIF= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_SIRKET_SINIFMesaj>(new HataTBL_SIRKET_SINIFMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_SIRKET_SINIF_MODEL model1 = new TBL_SIRKET_SINIF_MODEL();
                model1 = Propsırket_sınıfSecilen;
            if (await serviceAgent.Degistir__TBL_SIRKET_SINIF_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_SIRKET_SINIFMesaj>(new DegistirTBL_SIRKET_SINIFMesaj() { MesajTBL_SIRKET_SINIF= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_SIRKET_SINIFMesaj>(new DegistirTBL_SIRKET_SINIFMesaj() { MesajTBL_SIRKET_SINIF= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_SIRKET_SINIFMesaj>(new HataTBL_SIRKET_SINIFMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                Propsırket_sınıfListe = await serviceAgent.Listele__TBL_SIRKET_SINIF_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_SIRKET_SINIFMesaj>(new HataTBL_SIRKET_SINIFMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propsırket_sınıf = await serviceAgent.Bul_TBL_SIRKET_SINIF_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_SIRKET_SINIFMesaj>(new HataTBL_SIRKET_SINIFMesaj() { Hatamesaji = ex.ToString()});


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
