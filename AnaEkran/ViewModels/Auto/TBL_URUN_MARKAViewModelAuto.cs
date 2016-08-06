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
	public partial class TBL_URUN_MARKAViewModel  : ViewModelDetailBase< TBL_URUN_MARKAViewModel,TBL_URUN_MARKA_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_URUN_MARKAViewModel () { }
TBL_URUN_MARKA_MODEL model=new TBL_URUN_MARKA_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_URUN_MARKAViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_URUN_MARKA  tablosu modeli
        /// </summary>
     
        private TBL_URUN_MARKA_MODEL _Propurun_marka;

        public TBL_URUN_MARKA_MODEL Propurun_marka
        {
            get { return _Propurun_marka; }
            set { _Propurun_marka = value;
                NotifyPropertyChanged(m=>m.Propurun_marka);
                } 
        }
		 /// <summary>
        ///TBL_URUN_MARKA  tablosu Secilen
        /// </summary>
     
        private TBL_URUN_MARKA_MODEL _Propurun_markaSecilen;

        public TBL_URUN_MARKA_MODEL Propurun_markaSecilen
        {
            get { return _Propurun_markaSecilen; }
            set { _Propurun_markaSecilen = value;
                NotifyPropertyChanged(m=>m.Propurun_markaSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_URUN_MARKA  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_URUN_MARKA_MODEL> _Propurun_markaListe;

        public ObservableCollection<TBL_URUN_MARKA_MODEL> Propurun_markaListe
        {
            get { return _Propurun_markaListe; }
            set { _Propurun_markaListe = value; 
                NotifyPropertyChanged(m=>m.Propurun_markaListe);
                }
        }
         /// <summary>
        ///TBL_URUN_MARKA  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_URUN_MARKA_MODEL> _Propurun_markaListeSecilen;

        public ObservableCollection<TBL_URUN_MARKA_MODEL> Propurun_markaListeSecilen
        {
            get { return _Propurun_markaListeSecilen; }
            set { _Propurun_markaListeSecilen = value; 
                NotifyPropertyChanged(m=>m.Propurun_markaListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_URUN_MARKA_MODEL model1 = new TBL_URUN_MARKA_MODEL();
              //  model1 = Propurun_markaSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_URUN_MARKA_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_URUN_MARKAMesaj>(new EkleTBL_URUN_MARKAMesaj() { MesajTBL_URUN_MARKA= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_URUN_MARKAMesaj>(new EkleTBL_URUN_MARKAMesaj() { MesajTBL_URUN_MARKA= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_URUN_MARKAMesaj>(new HataTBL_URUN_MARKAMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_URUN_MARKA_MODEL model1 = new TBL_URUN_MARKA_MODEL();
                model1 = Propurun_markaSecilen;
                if (await serviceAgent.Sil__TBL_URUN_MARKA_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_URUN_MARKAMesaj>(new SilTBL_URUN_MARKAMesaj() { MesajTBL_URUN_MARKA= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_URUN_MARKAMesaj>(new SilTBL_URUN_MARKAMesaj() { MesajTBL_URUN_MARKA= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_URUN_MARKAMesaj>(new HataTBL_URUN_MARKAMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_URUN_MARKA_MODEL model1 = new TBL_URUN_MARKA_MODEL();
                model1 = Propurun_markaSecilen;
            if (await serviceAgent.Degistir__TBL_URUN_MARKA_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_URUN_MARKAMesaj>(new DegistirTBL_URUN_MARKAMesaj() { MesajTBL_URUN_MARKA= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_URUN_MARKAMesaj>(new DegistirTBL_URUN_MARKAMesaj() { MesajTBL_URUN_MARKA= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_URUN_MARKAMesaj>(new HataTBL_URUN_MARKAMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                Propurun_markaListe = await serviceAgent.Listele__TBL_URUN_MARKA_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_URUN_MARKAMesaj>(new HataTBL_URUN_MARKAMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propurun_marka = await serviceAgent.Bul_TBL_URUN_MARKA_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_URUN_MARKAMesaj>(new HataTBL_URUN_MARKAMesaj() { Hatamesaji = ex.ToString()});


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
