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
	public partial class TBL_SIRKET_TIPIViewModel  : ViewModelDetailBase< TBL_SIRKET_TIPIViewModel,TBL_SIRKET_TIPI_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_SIRKET_TIPIViewModel () { }
TBL_SIRKET_TIPI_MODEL model=new TBL_SIRKET_TIPI_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_SIRKET_TIPIViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_SIRKET_TIPI  tablosu modeli
        /// </summary>
     
        private TBL_SIRKET_TIPI_MODEL _Propsırket_tıpı;

        public TBL_SIRKET_TIPI_MODEL Propsırket_tıpı
        {
            get { return _Propsırket_tıpı; }
            set { _Propsırket_tıpı = value;
                NotifyPropertyChanged(m=>m.Propsırket_tıpı);
                } 
        }
		 /// <summary>
        ///TBL_SIRKET_TIPI  tablosu Secilen
        /// </summary>
     
        private TBL_SIRKET_TIPI_MODEL _Propsırket_tıpıSecilen;

        public TBL_SIRKET_TIPI_MODEL Propsırket_tıpıSecilen
        {
            get { return _Propsırket_tıpıSecilen; }
            set { _Propsırket_tıpıSecilen = value;
                NotifyPropertyChanged(m=>m.Propsırket_tıpıSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_SIRKET_TIPI  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_SIRKET_TIPI_MODEL> _Propsırket_tıpıListe;

        public ObservableCollection<TBL_SIRKET_TIPI_MODEL> Propsırket_tıpıListe
        {
            get { return _Propsırket_tıpıListe; }
            set { _Propsırket_tıpıListe = value; 
                NotifyPropertyChanged(m=>m.Propsırket_tıpıListe);
                }
        }
         /// <summary>
        ///TBL_SIRKET_TIPI  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_SIRKET_TIPI_MODEL> _Propsırket_tıpıListeSecilen;

        public ObservableCollection<TBL_SIRKET_TIPI_MODEL> Propsırket_tıpıListeSecilen
        {
            get { return _Propsırket_tıpıListeSecilen; }
            set { _Propsırket_tıpıListeSecilen = value; 
                NotifyPropertyChanged(m=>m.Propsırket_tıpıListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_SIRKET_TIPI_MODEL model1 = new TBL_SIRKET_TIPI_MODEL();
              //  model1 = Propsırket_tıpıSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_SIRKET_TIPI_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_SIRKET_TIPIMesaj>(new EkleTBL_SIRKET_TIPIMesaj() { MesajTBL_SIRKET_TIPI= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_SIRKET_TIPIMesaj>(new EkleTBL_SIRKET_TIPIMesaj() { MesajTBL_SIRKET_TIPI= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_SIRKET_TIPIMesaj>(new HataTBL_SIRKET_TIPIMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_SIRKET_TIPI_MODEL model1 = new TBL_SIRKET_TIPI_MODEL();
                model1 = Propsırket_tıpıSecilen;
                if (await serviceAgent.Sil__TBL_SIRKET_TIPI_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_SIRKET_TIPIMesaj>(new SilTBL_SIRKET_TIPIMesaj() { MesajTBL_SIRKET_TIPI= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_SIRKET_TIPIMesaj>(new SilTBL_SIRKET_TIPIMesaj() { MesajTBL_SIRKET_TIPI= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_SIRKET_TIPIMesaj>(new HataTBL_SIRKET_TIPIMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_SIRKET_TIPI_MODEL model1 = new TBL_SIRKET_TIPI_MODEL();
                model1 = Propsırket_tıpıSecilen;
            if (await serviceAgent.Degistir__TBL_SIRKET_TIPI_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_SIRKET_TIPIMesaj>(new DegistirTBL_SIRKET_TIPIMesaj() { MesajTBL_SIRKET_TIPI= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_SIRKET_TIPIMesaj>(new DegistirTBL_SIRKET_TIPIMesaj() { MesajTBL_SIRKET_TIPI= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_SIRKET_TIPIMesaj>(new HataTBL_SIRKET_TIPIMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                Propsırket_tıpıListe = await serviceAgent.Listele__TBL_SIRKET_TIPI_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_SIRKET_TIPIMesaj>(new HataTBL_SIRKET_TIPIMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propsırket_tıpı = await serviceAgent.Bul_TBL_SIRKET_TIPI_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_SIRKET_TIPIMesaj>(new HataTBL_SIRKET_TIPIMesaj() { Hatamesaji = ex.ToString()});


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
