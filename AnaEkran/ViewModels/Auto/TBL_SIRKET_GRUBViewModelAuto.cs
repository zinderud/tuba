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
	public partial class TBL_SIRKET_GRUBViewModel  : ViewModelDetailBase< TBL_SIRKET_GRUBViewModel,TBL_SIRKET_GRUB_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_SIRKET_GRUBViewModel () { }
TBL_SIRKET_GRUB_MODEL model=new TBL_SIRKET_GRUB_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_SIRKET_GRUBViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_SIRKET_GRUB  tablosu modeli
        /// </summary>
     
        private TBL_SIRKET_GRUB_MODEL _Propsırket_grub;

        public TBL_SIRKET_GRUB_MODEL Propsırket_grub
        {
            get { return _Propsırket_grub; }
            set { _Propsırket_grub = value;
                NotifyPropertyChanged(m=>m.Propsırket_grub);
                } 
        }
		 /// <summary>
        ///TBL_SIRKET_GRUB  tablosu Secilen
        /// </summary>
     
        private TBL_SIRKET_GRUB_MODEL _Propsırket_grubSecilen;

        public TBL_SIRKET_GRUB_MODEL Propsırket_grubSecilen
        {
            get { return _Propsırket_grubSecilen; }
            set { _Propsırket_grubSecilen = value;
                NotifyPropertyChanged(m=>m.Propsırket_grubSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_SIRKET_GRUB  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_SIRKET_GRUB_MODEL> _Propsırket_grubListe;

        public ObservableCollection<TBL_SIRKET_GRUB_MODEL> Propsırket_grubListe
        {
            get { return _Propsırket_grubListe; }
            set { _Propsırket_grubListe = value; 
                NotifyPropertyChanged(m=>m.Propsırket_grubListe);
                }
        }
         /// <summary>
        ///TBL_SIRKET_GRUB  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_SIRKET_GRUB_MODEL> _Propsırket_grubListeSecilen;

        public ObservableCollection<TBL_SIRKET_GRUB_MODEL> Propsırket_grubListeSecilen
        {
            get { return _Propsırket_grubListeSecilen; }
            set { _Propsırket_grubListeSecilen = value; 
                NotifyPropertyChanged(m=>m.Propsırket_grubListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_SIRKET_GRUB_MODEL model1 = new TBL_SIRKET_GRUB_MODEL();
              //  model1 = Propsırket_grubSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_SIRKET_GRUB_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_SIRKET_GRUBMesaj>(new EkleTBL_SIRKET_GRUBMesaj() { MesajTBL_SIRKET_GRUB= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_SIRKET_GRUBMesaj>(new EkleTBL_SIRKET_GRUBMesaj() { MesajTBL_SIRKET_GRUB= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_SIRKET_GRUBMesaj>(new HataTBL_SIRKET_GRUBMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_SIRKET_GRUB_MODEL model1 = new TBL_SIRKET_GRUB_MODEL();
                model1 = Propsırket_grubSecilen;
                if (await serviceAgent.Sil__TBL_SIRKET_GRUB_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_SIRKET_GRUBMesaj>(new SilTBL_SIRKET_GRUBMesaj() { MesajTBL_SIRKET_GRUB= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_SIRKET_GRUBMesaj>(new SilTBL_SIRKET_GRUBMesaj() { MesajTBL_SIRKET_GRUB= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_SIRKET_GRUBMesaj>(new HataTBL_SIRKET_GRUBMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_SIRKET_GRUB_MODEL model1 = new TBL_SIRKET_GRUB_MODEL();
                model1 = Propsırket_grubSecilen;
            if (await serviceAgent.Degistir__TBL_SIRKET_GRUB_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_SIRKET_GRUBMesaj>(new DegistirTBL_SIRKET_GRUBMesaj() { MesajTBL_SIRKET_GRUB= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_SIRKET_GRUBMesaj>(new DegistirTBL_SIRKET_GRUBMesaj() { MesajTBL_SIRKET_GRUB= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_SIRKET_GRUBMesaj>(new HataTBL_SIRKET_GRUBMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                Propsırket_grubListe = await serviceAgent.Listele__TBL_SIRKET_GRUB_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_SIRKET_GRUBMesaj>(new HataTBL_SIRKET_GRUBMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propsırket_grub = await serviceAgent.Bul_TBL_SIRKET_GRUB_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_SIRKET_GRUBMesaj>(new HataTBL_SIRKET_GRUBMesaj() { Hatamesaji = ex.ToString()});


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
