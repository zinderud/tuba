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
	public partial class TBL_URUN_STOKViewModel  : ViewModelDetailBase< TBL_URUN_STOKViewModel,TBL_URUN_STOK_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_URUN_STOKViewModel () { }
TBL_URUN_STOK_MODEL model=new TBL_URUN_STOK_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_URUN_STOKViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_URUN_STOK  tablosu modeli
        /// </summary>
     
        private TBL_URUN_STOK_MODEL _Propurun_stok;

        public TBL_URUN_STOK_MODEL Propurun_stok
        {
            get { return _Propurun_stok; }
            set { _Propurun_stok = value;
                NotifyPropertyChanged(m=>m.Propurun_stok);
                } 
        }
		 /// <summary>
        ///TBL_URUN_STOK  tablosu Secilen
        /// </summary>
     
        private TBL_URUN_STOK_MODEL _Propurun_stokSecilen;

        public TBL_URUN_STOK_MODEL Propurun_stokSecilen
        {
            get { return _Propurun_stokSecilen; }
            set { _Propurun_stokSecilen = value;
                NotifyPropertyChanged(m=>m.Propurun_stokSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_URUN_STOK  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_URUN_STOK_MODEL> _Propurun_stokListe;

        public ObservableCollection<TBL_URUN_STOK_MODEL> Propurun_stokListe
        {
            get { return _Propurun_stokListe; }
            set { _Propurun_stokListe = value; 
                NotifyPropertyChanged(m=>m.Propurun_stokListe);
                }
        }
         /// <summary>
        ///TBL_URUN_STOK  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_URUN_STOK_MODEL> _Propurun_stokListeSecilen;

        public ObservableCollection<TBL_URUN_STOK_MODEL> Propurun_stokListeSecilen
        {
            get { return _Propurun_stokListeSecilen; }
            set { _Propurun_stokListeSecilen = value; 
                NotifyPropertyChanged(m=>m.Propurun_stokListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_URUN_STOK_MODEL model1 = new TBL_URUN_STOK_MODEL();
              //  model1 = Propurun_stokSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_URUN_STOK_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_URUN_STOKMesaj>(new EkleTBL_URUN_STOKMesaj() { MesajTBL_URUN_STOK= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_URUN_STOKMesaj>(new EkleTBL_URUN_STOKMesaj() { MesajTBL_URUN_STOK= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_URUN_STOKMesaj>(new HataTBL_URUN_STOKMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_URUN_STOK_MODEL model1 = new TBL_URUN_STOK_MODEL();
                model1 = Propurun_stokSecilen;
                if (await serviceAgent.Sil__TBL_URUN_STOK_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_URUN_STOKMesaj>(new SilTBL_URUN_STOKMesaj() { MesajTBL_URUN_STOK= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_URUN_STOKMesaj>(new SilTBL_URUN_STOKMesaj() { MesajTBL_URUN_STOK= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_URUN_STOKMesaj>(new HataTBL_URUN_STOKMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_URUN_STOK_MODEL model1 = new TBL_URUN_STOK_MODEL();
                model1 = Propurun_stokSecilen;
            if (await serviceAgent.Degistir__TBL_URUN_STOK_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_URUN_STOKMesaj>(new DegistirTBL_URUN_STOKMesaj() { MesajTBL_URUN_STOK= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_URUN_STOKMesaj>(new DegistirTBL_URUN_STOKMesaj() { MesajTBL_URUN_STOK= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_URUN_STOKMesaj>(new HataTBL_URUN_STOKMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                Propurun_stokListe = await serviceAgent.Listele__TBL_URUN_STOK_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_URUN_STOKMesaj>(new HataTBL_URUN_STOKMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propurun_stok = await serviceAgent.Bul_TBL_URUN_STOK_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_URUN_STOKMesaj>(new HataTBL_URUN_STOKMesaj() { Hatamesaji = ex.ToString()});


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
