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
	public partial class TBL_BANKAViewModel  : ViewModelDetailBase< TBL_BANKAViewModel,TBL_BANKA_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_BANKAViewModel () { }
TBL_BANKA_MODEL model=new TBL_BANKA_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_BANKAViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_BANKA  tablosu modeli
        /// </summary>
     
        private TBL_BANKA_MODEL _Propbanka;

        public TBL_BANKA_MODEL Propbanka
        {
            get { return _Propbanka; }
            set { _Propbanka = value;
                NotifyPropertyChanged(m=>m.Propbanka);
                } 
        }
		 /// <summary>
        ///TBL_BANKA  tablosu Secilen
        /// </summary>
     
        private TBL_BANKA_MODEL _PropbankaSecilen;

        public TBL_BANKA_MODEL PropbankaSecilen
        {
            get { return _PropbankaSecilen; }
            set { _PropbankaSecilen = value;
                NotifyPropertyChanged(m=>m.PropbankaSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_BANKA  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_BANKA_MODEL> _PropbankaListe;

        public ObservableCollection<TBL_BANKA_MODEL> PropbankaListe
        {
            get { return _PropbankaListe; }
            set { _PropbankaListe = value; 
                NotifyPropertyChanged(m=>m.PropbankaListe);
                }
        }
         /// <summary>
        ///TBL_BANKA  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_BANKA_MODEL> _PropbankaListeSecilen;

        public ObservableCollection<TBL_BANKA_MODEL> PropbankaListeSecilen
        {
            get { return _PropbankaListeSecilen; }
            set { _PropbankaListeSecilen = value; 
                NotifyPropertyChanged(m=>m.PropbankaListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_BANKA_MODEL model1 = new TBL_BANKA_MODEL();
              //  model1 = PropbankaSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_BANKA_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_BANKAMesaj>(new EkleTBL_BANKAMesaj() { MesajTBL_BANKA= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_BANKAMesaj>(new EkleTBL_BANKAMesaj() { MesajTBL_BANKA= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_BANKAMesaj>(new HataTBL_BANKAMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_BANKA_MODEL model1 = new TBL_BANKA_MODEL();
                model1 = PropbankaSecilen;
                if (await serviceAgent.Sil__TBL_BANKA_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_BANKAMesaj>(new SilTBL_BANKAMesaj() { MesajTBL_BANKA= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_BANKAMesaj>(new SilTBL_BANKAMesaj() { MesajTBL_BANKA= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_BANKAMesaj>(new HataTBL_BANKAMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_BANKA_MODEL model1 = new TBL_BANKA_MODEL();
                model1 = PropbankaSecilen;
            if (await serviceAgent.Degistir__TBL_BANKA_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_BANKAMesaj>(new DegistirTBL_BANKAMesaj() { MesajTBL_BANKA= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_BANKAMesaj>(new DegistirTBL_BANKAMesaj() { MesajTBL_BANKA= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_BANKAMesaj>(new HataTBL_BANKAMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                PropbankaListe = await serviceAgent.Listele__TBL_BANKA_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_BANKAMesaj>(new HataTBL_BANKAMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propbanka = await serviceAgent.Bul_TBL_BANKA_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_BANKAMesaj>(new HataTBL_BANKAMesaj() { Hatamesaji = ex.ToString()});


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
