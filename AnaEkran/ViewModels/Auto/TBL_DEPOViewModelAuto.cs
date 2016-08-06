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
	public partial class TBL_DEPOViewModel  : ViewModelDetailBase< TBL_DEPOViewModel,TBL_DEPO_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_DEPOViewModel () { }
TBL_DEPO_MODEL model=new TBL_DEPO_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_DEPOViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_DEPO  tablosu modeli
        /// </summary>
     
        private TBL_DEPO_MODEL _Propdepo;

        public TBL_DEPO_MODEL Propdepo
        {
            get { return _Propdepo; }
            set { _Propdepo = value;
                NotifyPropertyChanged(m=>m.Propdepo);
                } 
        }
		 /// <summary>
        ///TBL_DEPO  tablosu Secilen
        /// </summary>
     
        private TBL_DEPO_MODEL _PropdepoSecilen;

        public TBL_DEPO_MODEL PropdepoSecilen
        {
            get { return _PropdepoSecilen; }
            set { _PropdepoSecilen = value;
                NotifyPropertyChanged(m=>m.PropdepoSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_DEPO  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_DEPO_MODEL> _PropdepoListe;

        public ObservableCollection<TBL_DEPO_MODEL> PropdepoListe
        {
            get { return _PropdepoListe; }
            set { _PropdepoListe = value; 
                NotifyPropertyChanged(m=>m.PropdepoListe);
                }
        }
         /// <summary>
        ///TBL_DEPO  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_DEPO_MODEL> _PropdepoListeSecilen;

        public ObservableCollection<TBL_DEPO_MODEL> PropdepoListeSecilen
        {
            get { return _PropdepoListeSecilen; }
            set { _PropdepoListeSecilen = value; 
                NotifyPropertyChanged(m=>m.PropdepoListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_DEPO_MODEL model1 = new TBL_DEPO_MODEL();
              //  model1 = PropdepoSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_DEPO_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_DEPOMesaj>(new EkleTBL_DEPOMesaj() { MesajTBL_DEPO= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_DEPOMesaj>(new EkleTBL_DEPOMesaj() { MesajTBL_DEPO= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_DEPOMesaj>(new HataTBL_DEPOMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_DEPO_MODEL model1 = new TBL_DEPO_MODEL();
                model1 = PropdepoSecilen;
                if (await serviceAgent.Sil__TBL_DEPO_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_DEPOMesaj>(new SilTBL_DEPOMesaj() { MesajTBL_DEPO= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_DEPOMesaj>(new SilTBL_DEPOMesaj() { MesajTBL_DEPO= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_DEPOMesaj>(new HataTBL_DEPOMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_DEPO_MODEL model1 = new TBL_DEPO_MODEL();
                model1 = PropdepoSecilen;
            if (await serviceAgent.Degistir__TBL_DEPO_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_DEPOMesaj>(new DegistirTBL_DEPOMesaj() { MesajTBL_DEPO= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_DEPOMesaj>(new DegistirTBL_DEPOMesaj() { MesajTBL_DEPO= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_DEPOMesaj>(new HataTBL_DEPOMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                PropdepoListe = await serviceAgent.Listele__TBL_DEPO_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_DEPOMesaj>(new HataTBL_DEPOMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propdepo = await serviceAgent.Bul_TBL_DEPO_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_DEPOMesaj>(new HataTBL_DEPOMesaj() { Hatamesaji = ex.ToString()});


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
