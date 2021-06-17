using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.CsharpConcepts
{
   public class TupleExamples
    {
        static void Main(string[] args)
        {
            HashSet<string> myhash1 = new HashSet<string>() { "StandardPackage", "NgsRfi", "PrepaidBarcodes", "SmartSeqKit", "SmartSeqRack", "SmartSeqLids", "PlateKitDNA", "PlateKitPCR", "PlateKitClone", "PlateCoupon", "FreeBarcodes", "SampleBox", "TubeBag", "SampleBag", "FreeSampleBag", "AddressSticker", "PCRPlate", "AgarPlate", "CapStrips", "PlasticFoil", "PlateBox", "SequencingProject", "SentPrimer", "OrderedPrimer", "ScaffoldDNA7249", "ScaffoldDNA7560", "ScaffoldDNA8064", "ScaffoldKit", "ScaffoldFoldB", "ScaffoldGelDye", "ShippingKit", "PlateKitMix", "Mix2Seq", "PrimerWalking", "TubeSeq", "Ready2Load", "PlateSeq", "Ready2LoadPlate", "NGSLabels", "PlateKitON", "Mix2SeqKitON", "NGSelectDNA", "UPSShippingKit", "LRTubeBarcode", "LRTubeNXP", "SRTBarcode", "SupremeRun", "LRP96BCs", "LRP48BCs", "SRP96", "SRP48", "SRPMulti", "PrimerSynthGATC", "EnclPrimerGATC", "LRTube", "SRPBarcode", "InViewExome", "NGSelectRNA", "NGSelectAmplicon", "NGSelectRTL", "IVMicroPB", "IVGenome", "IVTranscriptome", "IVMetagenome", "IVPanel", "NextGenSampleBarcode", "NGSPVS", "LIQUID", "IVOncotarget", "NGSProject", "LRPlate", "NGSReplace", "UPSLabelsNGSKN", "UPSLabelsGATC", "UPSLabelsAmpEBE", "NGSProjectEbersberg", "NGSProjectConstance", "NGSAddon", "LRPlate48", "LRPlate96", "INVIEWCRISPR", "NGSelectAmplicon2nd", "NGSFoodAnalysis", "Mix2SeqON", "LRTubeON", "PrimerSynthBB", "Milch", "Kaffee", "Zucker", "Boexle", "PrimerBarcodes", "NGSSARSCoV2", "NGSSanofi", "ColonySeqPlate", "ColSeqP", "PlateSeqKitColony", "PlateSeqLabel", "LR384Barcode", "LRPlate384", "NSSamplePCoupon", "NSCoveragePCoupon", "MiSSamplePCoupon", "MicrobiomeCoupon", "NGSBioITCoupon", "MicrobiomeITCoupon" };
            /*myhash1.Add("ramesha");
            myhash1.Add("rams");
            myhash1.Add("ramesha");
            myhash1.Add("rs");*/
            var url = "";
            foreach(string names in myhash1)
            {
                url = url + "&_producttype=" + names;
            }
           
            myhash1.Contains("url");
            Console.ReadLine();
        }
        

    }
}
