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
	public partial class TBL_ODEMEViewModel  : ViewModelDetailBase< TBL_ODEMEViewModel,TBL_ODEME_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_ODEMEViewModel () { }
TBL_ODEME_MODEL model=new TBL_ODEME_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_ODEMEViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_ODEME  tablosu modeli
        /// </summary>
     
        private TBL_ODEME_MODEL _Propodeme;

        public TBL_ODEME_MODEL Propodeme
        {
            get { return _Propodeme; }
            set { _Propodeme = value;
                NotifyPropertyChanged(m=>m.Propodeme);
                } 
        }
		 /// <summary>
        ///TBL_ODEME  tablosu Secilen
        /// </summary>
     
        private TBL_ODEME_MODEL _PropodemeSecilen;

        public TBL_ODEME_MODEL PropodemeSecilen
        {
            get { return _PropodemeSecilen; }
            set { _PropodemeSecilen = value;
                NotifyPropertyChanged(m=>m.PropodemeSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_ODEME  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_ODEME_MODEL> _PropodemeListe;

        public ObservableCollection<TBL_ODEME_MODEL> PropodemeListe
        {
            get { return _PropodemeListe; }
            set { _PropodemeListe = value; 
                NotifyPropertyChanged(m=>m.PropodemeListe);
                }
        }
         /// <summary>
        ///TBL_ODEME  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_ODEME_MODEL> _PropodemeListeSecilen;

        public ObservableCollection<TBL_ODEME_MODEL> PropodemeListeSecilen
        {
            get { return _PropodemeListeSecilen; }
            set { _PropodemeListeSecilen = value; 
                NotifyPropertyChanged(m=>m.PropodemeListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_ODEME_MODEL model1 = new TBL_ODEME_MODEL();
              //  model1 = PropodemeSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_ODEME_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_ODEMEMesaj>(new EkleTBL_ODEMEMesaj() { MesajTBL_ODEME= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_ODEMEMesaj>(new EkleTBL_ODEMEMesaj() { MesajTBL_ODEME= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_ODEMEMesaj>(new HataTBL_ODEMEMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_ODEME_MODEL model1 = new TBL_ODEME_MODEL();
                model1 = PropodemeSecilen;
                if (await serviceAgent.Sil__TBL_ODEME_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_ODEMEMesaj>(new SilTBL_ODEMEMesaj() { MesajTBL_ODEME= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_ODEMEMesaj>(new SilTBL_ODEMEMesaj() { MesajTBL_ODEME= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_ODEMEMesaj>(new HataTBL_ODEMEMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_ODEME_MODEL model1 = new TBL_ODEME_MODEL();
                model1 = PropodemeSecilen;
            if (await serviceAgent.Degistir__TBL_ODEME_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_ODEMEMesaj>(new DegistirTBL_ODEMEMesaj() { MesajTBL_ODEME= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_ODEMEMesaj>(new DegistirTBL_ODEMEMesaj() { MesajTBL_ODEME= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_ODEMEMesaj>(new HataTBL_ODEMEMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                PropodemeListe = await serviceAgent.Listele__TBL_ODEME_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_ODEMEMesaj>(new HataTBL_ODEMEMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propodeme = await serviceAgent.Bul_TBL_ODEME_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_ODEMEMesaj>(new HataTBL_ODEMEMesaj() { Hatamesaji = ex.ToString()});


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
