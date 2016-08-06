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
	public partial class TBL_URUNViewModel  : ViewModelDetailBase< TBL_URUNViewModel,TBL_URUN_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_URUNViewModel () { }
TBL_URUN_MODEL model=new TBL_URUN_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_URUNViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_URUN  tablosu modeli
        /// </summary>
     
        private TBL_URUN_MODEL _Propurun;

        public TBL_URUN_MODEL Propurun
        {
            get { return _Propurun; }
            set { _Propurun = value;
                NotifyPropertyChanged(m=>m.Propurun);
                } 
        }
		 /// <summary>
        ///TBL_URUN  tablosu Secilen
        /// </summary>
     
        private TBL_URUN_MODEL _PropurunSecilen;

        public TBL_URUN_MODEL PropurunSecilen
        {
            get { return _PropurunSecilen; }
            set { _PropurunSecilen = value;
                NotifyPropertyChanged(m=>m.PropurunSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_URUN  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_URUN_MODEL> _PropurunListe;

        public ObservableCollection<TBL_URUN_MODEL> PropurunListe
        {
            get { return _PropurunListe; }
            set { _PropurunListe = value; 
                NotifyPropertyChanged(m=>m.PropurunListe);
                }
        }
         /// <summary>
        ///TBL_URUN  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_URUN_MODEL> _PropurunListeSecilen;

        public ObservableCollection<TBL_URUN_MODEL> PropurunListeSecilen
        {
            get { return _PropurunListeSecilen; }
            set { _PropurunListeSecilen = value; 
                NotifyPropertyChanged(m=>m.PropurunListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_URUN_MODEL model1 = new TBL_URUN_MODEL();
              //  model1 = PropurunSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_URUN_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_URUNMesaj>(new EkleTBL_URUNMesaj() { MesajTBL_URUN= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_URUNMesaj>(new EkleTBL_URUNMesaj() { MesajTBL_URUN= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_URUNMesaj>(new HataTBL_URUNMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_URUN_MODEL model1 = new TBL_URUN_MODEL();
                model1 = PropurunSecilen;
                if (await serviceAgent.Sil__TBL_URUN_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_URUNMesaj>(new SilTBL_URUNMesaj() { MesajTBL_URUN= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_URUNMesaj>(new SilTBL_URUNMesaj() { MesajTBL_URUN= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_URUNMesaj>(new HataTBL_URUNMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_URUN_MODEL model1 = new TBL_URUN_MODEL();
                model1 = PropurunSecilen;
            if (await serviceAgent.Degistir__TBL_URUN_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_URUNMesaj>(new DegistirTBL_URUNMesaj() { MesajTBL_URUN= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_URUNMesaj>(new DegistirTBL_URUNMesaj() { MesajTBL_URUN= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_URUNMesaj>(new HataTBL_URUNMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                PropurunListe = await serviceAgent.Listele__TBL_URUN_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_URUNMesaj>(new HataTBL_URUNMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propurun = await serviceAgent.Bul_TBL_URUN_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_URUNMesaj>(new HataTBL_URUNMesaj() { Hatamesaji = ex.ToString()});


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
