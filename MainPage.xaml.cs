using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Basics_Of_Physics.Resources;

namespace Basics_Of_Physics
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnDefinitionOfPhysics_Click(object sender, RoutedEventArgs e)
        {
           
            NavigationService.Navigate(new Uri("/Definitions/Definition_OF_Physics.xaml", UriKind.Relative));
            
        }

        private void PhoneApplicationPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            while (NavigationService.CanGoBack)
            {
                NavigationService.RemoveBackEntry();
            }
        }

        private void btnAcceleration_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Acceleration.xaml", UriKind.Relative));

        }

        private void btnAbsoluteZero_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/AbsoluteZero.xaml", UriKind.Relative));

        }

        private void btnAngularMomentum_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/AngularMomentum.xaml", UriKind.Relative));

        }

        private void btnAtom_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Atom.xaml", UriKind.Relative));

        }

        private void btnBigBang_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/BigBang.xaml", UriKind.Relative));

        }

        private void btnBlackHoles_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/BlackHoles.xaml", UriKind.Relative));

        }

        private void btnCentrifugalForce_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/CentrifugalForce.xaml", UriKind.Relative));

        }

        private void btnCentripetalForce_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/CentripetalForce.xaml", UriKind.Relative));

        }

        private void btnChaos_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Chaos.xaml", UriKind.Relative));

        }

        private void btnClassicalMechanics_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/ClassicalMechanics.xaml", UriKind.Relative));

        }

        private void btnConductivity_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Conductivity.xaml", UriKind.Relative));
        }

        private void btnConservationOfEnergy_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/ConservationOfEnergy.xaml", UriKind.Relative));


        }

        private void btnCorrespondencePrinciple_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/CorrespondencePrinciple.xaml", UriKind.Relative));
        }

        private void btnEarthMagneticField_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/EarthMagneticField.xaml", UriKind.Relative));

        }

        private void btnElasticity_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Elasticity.xaml", UriKind.Relative));

        }

        private void btnElectricity_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Electricity.xaml", UriKind.Relative));

        }

        private void btnElectromagneticForce_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/ElectromagneticForce.xaml", UriKind.Relative));

        }

        private void btnElectromagneticRadiation_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/ElectromagneticRadiation.xaml", UriKind.Relative));

        }

        private void btnElectromagnetism_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Electromagnetism.xaml", UriKind.Relative));

        }

        private void btnElectron_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Electron.xaml", UriKind.Relative));

        }

        private void btnEntropy_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Entropy.xaml", UriKind.Relative));

        }

        private void btnFirstLawOfMotion_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/FirstLawOfMotion.xaml", UriKind.Relative));

        }

        private void btnFirstLawOfThermodynamics_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/FirstLawOfThermodynamics.xaml", UriKind.Relative));

        }

        private void btnForce_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Force.xaml", UriKind.Relative));

        }

        private void btnFriction_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Friction.xaml", UriKind.Relative));

        }

        private void btnGaussLaw_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/GaussLaw.xaml", UriKind.Relative));

        }

        private void btnGeneralRelativity_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/GeneralRelativity.xaml", UriKind.Relative));

        }

        private void btnGravity_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Gravity.xaml", UriKind.Relative));

        }

        private void btnHeat_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Heat.xaml", UriKind.Relative));

        }

        private void btnHeisenbergUncertaintyPrinciple_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/HeisenbergUncertaintyPrinciple.xaml", UriKind.Relative));

        }

        private void btnKineticEnergy_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/KineticEnergy.xaml", UriKind.Relative));

        }

        private void btnLaser_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Laser.xaml", UriKind.Relative));

        }

        private void btnLight_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Light.xaml", UriKind.Relative));

        }

        private void btnMagnetism_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Magnetism.xaml", UriKind.Relative));

        }

        private void btnMass_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Mass.xaml", UriKind.Relative));

        }

        private void btnMatter_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Matter.xaml", UriKind.Relative));

        }

        private void btnMaxwellLawsOfElectromagnetism_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/MaxwellLawsOfElectromagnetism.xaml", UriKind.Relative));

        }

        private void btnMomentum_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Momentum.xaml", UriKind.Relative));

        }

        private void btnNanotechnology_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Nanotechnology.xaml", UriKind.Relative));

        }

        private void btnNeutrinos_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Neutrinos.xaml", UriKind.Relative));
        }

        private void btnNeutron_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Neutron.xaml", UriKind.Relative));

        }

        private void btnNecularFission_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/NuclearFission.xaml", UriKind.Relative));

        }

        private void btnNecularFusion_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/NuclearFusion.xaml", UriKind.Relative));

        }

        private void btnOhmsLaw_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/OhmsLaw.xaml", UriKind.Relative));

        }

        private void btnPhoton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Photon.xaml", UriKind.Relative));
        }

        private void btnPolarization_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Polarization.xaml", UriKind.Relative));

        }

        private void btnPotentialEnergy_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/PotentialEnergy.xaml", UriKind.Relative));

        }

        private void btnProjectileMotion_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/ProjectileMotion.xaml", UriKind.Relative));
        }

        private void btnQuantization_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Quantization.xaml", UriKind.Relative));

        }

        private void btnQuantumMechanics_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/QuantumMechanics.xaml", UriKind.Relative));

        }

        private void btnReflection_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Reflection.xaml", UriKind.Relative));

        }

        private void btnRefraction_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Refraction.xaml", UriKind.Relative));

        }

        private void btnScattering_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Scattering.xaml", UriKind.Relative));

        }

        private void btnSecondLawOfMotion_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/SecondLawOfMotion.xaml", UriKind.Relative));

        }

        private void btnSecondLawOfThermodynamics_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/SecondLawOfThermodynamics.xaml", UriKind.Relative));

        }

        private void btnSuperconductivity_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Superconductivity.xaml", UriKind.Relative));

        }

        private void btnTheoryOfRelativity_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/TheoryOfRelativity.xaml", UriKind.Relative));

        }

        private void btnThermalEnergy_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/ThermalEnergy.xaml", UriKind.Relative));

        }

        private void btnThirdLawOfMotion_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/ThirdLawOfMotion.xaml", UriKind.Relative));

        }

        private void btnThirdLawOfThermodynamics_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/ThirdLawOfThermodynamics.xaml", UriKind.Relative));

        }

        private void btnWaveParticleDuality_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/WaveParticleDuality.xaml", UriKind.Relative));

        }

        private void btnWaves_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Waves.xaml", UriKind.Relative));

        }

        private void btnWork_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Definitions/Work.xaml", UriKind.Relative));

        }
        
    }
}