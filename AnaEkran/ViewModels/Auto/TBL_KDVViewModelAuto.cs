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
	public partial class TBL_KDVViewModel  : ViewModelDetailBase< TBL_KDVViewModel,TBL_KDV_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_KDVViewModel () { }
TBL_KDV_MODEL model=new TBL_KDV_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_KDVViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_KDV  tablosu modeli
        /// </summary>
     
        private TBL_KDV_MODEL _Propkdv;

        public TBL_KDV_MODEL Propkdv
        {
            get { return _Propkdv; }
            set { _Propkdv = value;
                NotifyPropertyChanged(m=>m.Propkdv);
                } 
        }
		 /// <summary>
        ///TBL_KDV  tablosu Secilen
        /// </summary>
     
        private TBL_KDV_MODEL _PropkdvSecilen;

        public TBL_KDV_MODEL PropkdvSecilen
        {
            get { return _PropkdvSecilen; }
            set { _PropkdvSecilen = value;
                NotifyPropertyChanged(m=>m.PropkdvSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_KDV  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_KDV_MODEL> _PropkdvListe;

        public ObservableCollection<TBL_KDV_MODEL> PropkdvListe
        {
            get { return _PropkdvListe; }
            set { _PropkdvListe = value; 
                NotifyPropertyChanged(m=>m.PropkdvListe);
                }
        }
         /// <summary>
        ///TBL_KDV  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_KDV_MODEL> _PropkdvListeSecilen;

        public ObservableCollection<TBL_KDV_MODEL> PropkdvListeSecilen
        {
            get { return _PropkdvListeSecilen; }
            set { _PropkdvListeSecilen = value; 
                NotifyPropertyChanged(m=>m.PropkdvListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_KDV_MODEL model1 = new TBL_KDV_MODEL();
              //  model1 = PropkdvSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_KDV_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_KDVMesaj>(new EkleTBL_KDVMesaj() { MesajTBL_KDV= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_KDVMesaj>(new EkleTBL_KDVMesaj() { MesajTBL_KDV= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_KDVMesaj>(new HataTBL_KDVMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_KDV_MODEL model1 = new TBL_KDV_MODEL();
                model1 = PropkdvSecilen;
                if (await serviceAgent.Sil__TBL_KDV_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_KDVMesaj>(new SilTBL_KDVMesaj() { MesajTBL_KDV= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_KDVMesaj>(new SilTBL_KDVMesaj() { MesajTBL_KDV= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_KDVMesaj>(new HataTBL_KDVMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_KDV_MODEL model1 = new TBL_KDV_MODEL();
                model1 = PropkdvSecilen;
            if (await serviceAgent.Degistir__TBL_KDV_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_KDVMesaj>(new DegistirTBL_KDVMesaj() { MesajTBL_KDV= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_KDVMesaj>(new DegistirTBL_KDVMesaj() { MesajTBL_KDV= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_KDVMesaj>(new HataTBL_KDVMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                PropkdvListe = await serviceAgent.Listele__TBL_KDV_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_KDVMesaj>(new HataTBL_KDVMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propkdv = await serviceAgent.Bul_TBL_KDV_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_KDVMesaj>(new HataTBL_KDVMesaj() { Hatamesaji = ex.ToString()});


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
