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
	public partial class TBL_SIRKETViewModel  : ViewModelDetailBase< TBL_SIRKETViewModel,TBL_SIRKET_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_SIRKETViewModel () { }
TBL_SIRKET_MODEL model=new TBL_SIRKET_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_SIRKETViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_SIRKET  tablosu modeli
        /// </summary>
     
        private TBL_SIRKET_MODEL _Propsırket;

        public TBL_SIRKET_MODEL Propsırket
        {
            get { return _Propsırket; }
            set { _Propsırket = value;
                NotifyPropertyChanged(m=>m.Propsırket);
                } 
        }
		 /// <summary>
        ///TBL_SIRKET  tablosu Secilen
        /// </summary>
     
        private TBL_SIRKET_MODEL _PropsırketSecilen;

        public TBL_SIRKET_MODEL PropsırketSecilen
        {
            get { return _PropsırketSecilen; }
            set { _PropsırketSecilen = value;
                NotifyPropertyChanged(m=>m.PropsırketSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_SIRKET  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_SIRKET_MODEL> _PropsırketListe;

        public ObservableCollection<TBL_SIRKET_MODEL> PropsırketListe
        {
            get { return _PropsırketListe; }
            set { _PropsırketListe = value; 
                NotifyPropertyChanged(m=>m.PropsırketListe);
                }
        }
         /// <summary>
        ///TBL_SIRKET  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_SIRKET_MODEL> _PropsırketListeSecilen;

        public ObservableCollection<TBL_SIRKET_MODEL> PropsırketListeSecilen
        {
            get { return _PropsırketListeSecilen; }
            set { _PropsırketListeSecilen = value; 
                NotifyPropertyChanged(m=>m.PropsırketListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_SIRKET_MODEL model1 = new TBL_SIRKET_MODEL();
              //  model1 = PropsırketSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_SIRKET_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_SIRKETMesaj>(new EkleTBL_SIRKETMesaj() { MesajTBL_SIRKET= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_SIRKETMesaj>(new EkleTBL_SIRKETMesaj() { MesajTBL_SIRKET= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_SIRKETMesaj>(new HataTBL_SIRKETMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_SIRKET_MODEL model1 = new TBL_SIRKET_MODEL();
                model1 = PropsırketSecilen;
                if (await serviceAgent.Sil__TBL_SIRKET_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_SIRKETMesaj>(new SilTBL_SIRKETMesaj() { MesajTBL_SIRKET= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_SIRKETMesaj>(new SilTBL_SIRKETMesaj() { MesajTBL_SIRKET= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_SIRKETMesaj>(new HataTBL_SIRKETMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_SIRKET_MODEL model1 = new TBL_SIRKET_MODEL();
                model1 = PropsırketSecilen;
            if (await serviceAgent.Degistir__TBL_SIRKET_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_SIRKETMesaj>(new DegistirTBL_SIRKETMesaj() { MesajTBL_SIRKET= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_SIRKETMesaj>(new DegistirTBL_SIRKETMesaj() { MesajTBL_SIRKET= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_SIRKETMesaj>(new HataTBL_SIRKETMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                PropsırketListe = await serviceAgent.Listele__TBL_SIRKET_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_SIRKETMesaj>(new HataTBL_SIRKETMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propsırket = await serviceAgent.Bul_TBL_SIRKET_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_SIRKETMesaj>(new HataTBL_SIRKETMesaj() { Hatamesaji = ex.ToString()});


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
