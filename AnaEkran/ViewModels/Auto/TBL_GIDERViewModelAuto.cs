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
	public partial class TBL_GIDERViewModel  : ViewModelDetailBase< TBL_GIDERViewModel,TBL_GIDER_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_GIDERViewModel () { }
TBL_GIDER_MODEL model=new TBL_GIDER_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_GIDERViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_GIDER  tablosu modeli
        /// </summary>
     
        private TBL_GIDER_MODEL _Propgıder;

        public TBL_GIDER_MODEL Propgıder
        {
            get { return _Propgıder; }
            set { _Propgıder = value;
                NotifyPropertyChanged(m=>m.Propgıder);
                } 
        }
		 /// <summary>
        ///TBL_GIDER  tablosu Secilen
        /// </summary>
     
        private TBL_GIDER_MODEL _PropgıderSecilen;

        public TBL_GIDER_MODEL PropgıderSecilen
        {
            get { return _PropgıderSecilen; }
            set { _PropgıderSecilen = value;
                NotifyPropertyChanged(m=>m.PropgıderSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_GIDER  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_GIDER_MODEL> _PropgıderListe;

        public ObservableCollection<TBL_GIDER_MODEL> PropgıderListe
        {
            get { return _PropgıderListe; }
            set { _PropgıderListe = value; 
                NotifyPropertyChanged(m=>m.PropgıderListe);
                }
        }
         /// <summary>
        ///TBL_GIDER  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_GIDER_MODEL> _PropgıderListeSecilen;

        public ObservableCollection<TBL_GIDER_MODEL> PropgıderListeSecilen
        {
            get { return _PropgıderListeSecilen; }
            set { _PropgıderListeSecilen = value; 
                NotifyPropertyChanged(m=>m.PropgıderListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_GIDER_MODEL model1 = new TBL_GIDER_MODEL();
              //  model1 = PropgıderSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_GIDER_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_GIDERMesaj>(new EkleTBL_GIDERMesaj() { MesajTBL_GIDER= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_GIDERMesaj>(new EkleTBL_GIDERMesaj() { MesajTBL_GIDER= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_GIDERMesaj>(new HataTBL_GIDERMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_GIDER_MODEL model1 = new TBL_GIDER_MODEL();
                model1 = PropgıderSecilen;
                if (await serviceAgent.Sil__TBL_GIDER_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_GIDERMesaj>(new SilTBL_GIDERMesaj() { MesajTBL_GIDER= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_GIDERMesaj>(new SilTBL_GIDERMesaj() { MesajTBL_GIDER= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_GIDERMesaj>(new HataTBL_GIDERMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_GIDER_MODEL model1 = new TBL_GIDER_MODEL();
                model1 = PropgıderSecilen;
            if (await serviceAgent.Degistir__TBL_GIDER_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_GIDERMesaj>(new DegistirTBL_GIDERMesaj() { MesajTBL_GIDER= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_GIDERMesaj>(new DegistirTBL_GIDERMesaj() { MesajTBL_GIDER= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_GIDERMesaj>(new HataTBL_GIDERMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                PropgıderListe = await serviceAgent.Listele__TBL_GIDER_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_GIDERMesaj>(new HataTBL_GIDERMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propgıder = await serviceAgent.Bul_TBL_GIDER_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_GIDERMesaj>(new HataTBL_GIDERMesaj() { Hatamesaji = ex.ToString()});


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
