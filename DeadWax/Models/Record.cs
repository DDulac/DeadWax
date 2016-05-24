using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeadWax.Models
{
    #region Record Enums
    public enum PressingType
    {
        Retail,
        Promotional,
        Demonstration,
        Test,
        Audition,
        RadioTVOnly,        
    }

    public enum JacketType
    {
        SingleDisc,
        DoubleDisc,
        Gatefold,
        OpenThrough,
        Trifold,
        FoldoverConvertable,
        ClearpolyMylar,
        MPackGatefold,
        JacketFlats,
        Custom
    }

    public enum JacketExterior
    {
        SlipCase,
        Violators,
        ObiStips,
        ShrinkWrap,
        RecordBoxes,
        Custom
    }

    public enum JacketFinish
    {
        Matte,
        HighGloss,
        UltraViolet,
        AqueousGlossCoating,
        SpotVarnish,
        FoilStamping,
        Lamination,
        Embossing,
        BlindEmbossing,
        Debossing,
        DieCuts,
        Custom
    }

    public enum SleeveType
    {
        None,
        Paper,
        Plastic,
        Custom
    }

    public enum VinylFormat
    {
        LP,
        EP,
        EPSingle,
        MaxiSingle,
        Custom
    }

    public enum Sound
    {
        Monophonic,
        Sterophonic,
        Quadraphonic,
        Custom
    }

    public enum VinylSize
    {
        Seven,
        Ten,
        Tweleve,
        Custom
    }

    public enum VinylWeight
    {
        Flexi,
        Forty,
        OneHundred,
        OneTwenty,
        OneFifty,
        OneEight,
        Custom
    }

    public enum VinylShape
    {
        Round,
        Square,
        Triangle,
        Custom
    }

    public enum PlaybackSpeed
    {
        ThirtyThree,
        FortyFive,
        SeventyEight,
        Custom
    }

    public enum VinylFinish
    {
        Matte,
        Gloss,
        Picture,
        Custom
    }

    public enum VinylColor
    {
        Black,
        Picture,
        SingleOpaque,
        SingleClear,
        DoubleSplitOpaque,
        DoubleSplitClear,
        MultipleOpaque,
        MultipleClear,
        Custom
    }

    public enum Grade
    {
        Mint,
        NearMint,
        Excellent,
        VeryGoodPlus,
        VeryGood,
        VeryGoodMinus,
        GoodPlus,
        Good,
        Fair,
        Poor
    }
    #endregion

    public class Record
    {
        #region Properties
        public long Id { get; set; }

        public int ArtistId { get; set; }
        public int PublisherId { get; set; }
        public int ExecutiveProducerId { get; set; }
        public int ProducerId { get; set; }
        public int EngineerId { get; set; }
        public int StudioId { get; set; }

        public string Title { get; set; }
        public string Genre { get; set; }
        public string ImageURL { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool Import { get; set; }
        public PressingType PressingType { get; set; }
        public int DiscCount { get; set; }
        public JacketType JacketType { get; set; }
        public JacketExterior JacketExterior { get; set; }
        public JacketFinish JacketFinish { get; set; }
        public SleeveType Sleeve { get; set; }
        public VinylFormat Format { get; set; }
        public Sound Sound { get; set; }
        public VinylSize Size { get; set; }
        public VinylWeight Weight { get; set; }
        public VinylShape Shape { get; set; }
        public PlaybackSpeed Speed { get; set; }
        public VinylFinish Finish { get; set; }
        public VinylColor Color { get; set; }
        public int Tracks { get; set; }
        public bool HiddenTracks { get; set; }
        public bool Lyrics { get; set; }
        public Grade JacketGrade { get; set; }
        public Grade SleeveGrade { get; set; }
        public Grade VinylGrade { get; set; }
        public bool Scratched { get; set; }
        public Grade OverallGrade { get; set; }
        public bool PolyBagged { get; set; }
        public string Description { get; set; }
        #endregion

        //Constructor
        public Record()
        {

        }

    }
}