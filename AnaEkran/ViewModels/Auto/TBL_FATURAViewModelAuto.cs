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
	public partial class TBL_FATURAViewModel  : ViewModelDetailBase< TBL_FATURAViewModel,TBL_FATURA_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_FATURAViewModel () { }
TBL_FATURA_MODEL model=new TBL_FATURA_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_FATURAViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_FATURA  tablosu modeli
        /// </summary>
     
        private TBL_FATURA_MODEL _Propfatura;

        public TBL_FATURA_MODEL Propfatura
        {
            get { return _Propfatura; }
            set { _Propfatura = value;
                NotifyPropertyChanged(m=>m.Propfatura);
                } 
        }
		 /// <summary>
        ///TBL_FATURA  tablosu Secilen
        /// </summary>
     
        private TBL_FATURA_MODEL _PropfaturaSecilen;

        public TBL_FATURA_MODEL PropfaturaSecilen
        {
            get { return _PropfaturaSecilen; }
            set { _PropfaturaSecilen = value;
                NotifyPropertyChanged(m=>m.PropfaturaSecilen);
                 } 
        }
        
		 /// <summary>
        ///TBL_FATURA  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_FATURA_MODEL> _PropfaturaListe;

        public ObservableCollection<TBL_FATURA_MODEL> PropfaturaListe
        {
            get { return _PropfaturaListe; }
            set { _PropfaturaListe = value; 
                NotifyPropertyChanged(m=>m.PropfaturaListe);
                }
        }
         /// <summary>
        ///TBL_FATURA  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_FATURA_MODEL> _PropfaturaListeSecilen;

        public ObservableCollection<TBL_FATURA_MODEL> PropfaturaListeSecilen
        {
            get { return _PropfaturaListeSecilen; }
            set { _PropfaturaListeSecilen = value; 
                NotifyPropertyChanged(m=>m.PropfaturaListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_FATURA_MODEL model1 = new TBL_FATURA_MODEL();
              //  model1 = PropfaturaSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_FATURA_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_FATURAMesaj>(new EkleTBL_FATURAMesaj() { MesajTBL_FATURA= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_FATURAMesaj>(new EkleTBL_FATURAMesaj() { MesajTBL_FATURA= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_FATURAMesaj>(new HataTBL_FATURAMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_FATURA_MODEL model1 = new TBL_FATURA_MODEL();
                model1 = PropfaturaSecilen;
                if (await serviceAgent.Sil__TBL_FATURA_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_FATURAMesaj>(new SilTBL_FATURAMesaj() { MesajTBL_FATURA= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_FATURAMesaj>(new SilTBL_FATURAMesaj() { MesajTBL_FATURA= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_FATURAMesaj>(new HataTBL_FATURAMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_FATURA_MODEL model1 = new TBL_FATURA_MODEL();
                model1 = PropfaturaSecilen;
            if (await serviceAgent.Degistir__TBL_FATURA_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_FATURAMesaj>(new DegistirTBL_FATURAMesaj() { MesajTBL_FATURA= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_FATURAMesaj>(new DegistirTBL_FATURAMesaj() { MesajTBL_FATURA= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_FATURAMesaj>(new HataTBL_FATURAMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                PropfaturaListe = await serviceAgent.Listele__TBL_FATURA_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_FATURAMesaj>(new HataTBL_FATURAMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propfatura = await serviceAgent.Bul_TBL_FATURA_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_FATURAMesaj>(new HataTBL_FATURAMesaj() { Hatamesaji = ex.ToString()});


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
