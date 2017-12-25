using PoeHUD.Hud.Settings;
using PoeHUD.Plugins;
using System.Windows.Forms;

namespace FlaskManager
{
    internal class FlaskManagerSettings : SettingsBase
    {
        public FlaskManagerSettings()
        {
            #region Default Settings
            //plugin
            Enable = false;
            //HP/MANA
            AutoFlask = false;
            PerHpFlask = new RangeNode<int>(60, 0, 100);
            InstantPerHpFlask = new RangeNode<int>(35, 0, 100);
            PerManaFlask = new RangeNode<float>(25f, 0, 100);
			InstantPerMpFlask = new RangeNode<int>(35, 0, 100);
            MinManaFlask = new RangeNode<float>(50, 0, 100);
            DisableLifeSecUse = false;
            //Ailment Flask
            RemAilment = false;
            RemFrozen = false;
            RemShocked = false;
            RemBurning = false;
            RemCurse = false;
            RemPoison = false;
            RemBleed = false;
            CorrptCount = new RangeNode<int>(10, 1, 20);
            AilmentDur = new RangeNode<int>(0, 0, 5000);
            //Quicksilver
			SpeedFlaskEnable = false;
            ShouldDrinkSilverQuickSilverTogether = true;
            QuicksilverEnable = false;
            QuicksilverDurration = new RangeNode<float>(500f, 0f, 5000f);
            QuicksilverUseWhenCharges = new RangeNode<int>(0, 0, 100);
			//SilverFlask
            SilverFlaskEnable = false;
            SilverFlaskDurration = new RangeNode<float>(500f, 0f, 6000f);
            SilverFlaskUseWhenCharges = new RangeNode<int>(0, 0, 100);
            //Defensive Flask
            DefFlaskEnable = false;
            HpDefensive = new RangeNode<int>(50, 0, 100);
            EsDefensive = new RangeNode<int>(50, 0, 100);
            DefensiveDelay = new RangeNode<float>(3000f, 0f, 10000f);
            DefensiveDrinkAll = true;
            //Offensive Flask
            OffFlaskEnable = false;
            HpOffensive = new RangeNode<int>(50, 0, 100);
            EsOffensive = new RangeNode<int>(50, 0, 100);
            OffensiveDelay = new RangeNode<float>(3000f, 0f, 10000f);
            UseWhileKeyPressed = false;
            KeyPressed = Keys.T;
            OffensiveDrinkAll = true;
            OffensiveWhenAttacking = false;
            OffensiveWhenLifeEs = true;
            TreatOffenAsDef = false;
            OffensiveUseWhenCharges = new RangeNode<int>(0, 0, 100);
            //Unique Flask
            UniqFlaskEnable = false;
            //Vaal Haste
            VaalHasteEnable = false;
            HasteUseKey = Keys.E;
            //Defensive Skill
            DefSkillEnable = false;
            HpDefensiveSkill = new RangeNode<int>(50, 0, 100);
            EsDefensiveSkill = new RangeNode<int>(50, 0, 100);
            DefensiveSkillDelay = new RangeNode<float>(3000f, 0f, 10000f);
            SkillUseKey = Keys.R;
            //Defensive Skill 2
            DefSkillEnable2 = false;
            HpDefensiveSkill2 = new RangeNode<int>(50, 0, 100);
            EsDefensiveSkill2 = new RangeNode<int>(50, 0, 100);
            DefensiveSkillDelay2 = new RangeNode<float>(3000f, 0f, 10000f);
            SkillUseKey2 = Keys.W;
            //Movement Skill
            MoveEnable = false;
            MoveDurration = new RangeNode<float>(500f, 0f, 5000f);
            MoveUseKey = Keys.Q;
            ShiftMod = true;
            //MoveSkillDelay = new RangeNode<float>(500f, 0f, 10000f);
            //Recastables
            RecastableEnable = false;
            GolemsEnable = false;
            FireElEnable = false;
            FireElKey = Keys.W;
            LightningElEnable = false;
            LightningElKey = Keys.R;
            RockElEnable = false;
            RockElKey = Keys.R;
            IceElEnable = false;
            IceElKey = Keys.R;
            ChaosElEnable = false;
            ChaosElKey = Keys.R;
            BuffsEnable = false;
            BloodRageEnable = false;
            BRTime = new RangeNode<float>(3000f, 0f, 10000f);
            BloodRageKey = Keys.R;
            EndurChargeEnable = false;
            ECTime = new RangeNode<float>(3000f, 0f, 10000f);
            EndurCryKey = Keys.R;
            // Settings
            // Flask UI Settings
            FlaskUiEnable = false;
            FlaskPositionX = new RangeNode<float>(28.0f, 0.0f, 100.0f);
            FlaskPositionY = new RangeNode<float>(83.0f, 0.0f, 100.0f);
            FlaskTextSize = new RangeNode<int>(15, 15, 60);
            //Buff UI Settings
            BuffUiEnable = false;
            BuffPositionX = new RangeNode<float>(0.0f, 0.0f, 100.0f);
            BuffPositionY = new RangeNode<float>(10.0f, 0.0f, 100.0f);
            BuffTextSize = new RangeNode<int>(15, 15, 60);
            EnableFlaskAuraBuff = true;
            //Debug
            DebugMode = false;
            //Flask Slot Enable/Disable
            FlaskSlot1Enable = true;
            FlaskSlot2Enable = true;
            FlaskSlot3Enable = true;
            FlaskSlot4Enable = true;
            FlaskSlot5Enable = true;

            //Charges Reduction from Items/Tree (0 to disable it)
            ChargeReduction = new RangeNode<float>(0f, 0f, 100f);
            //About
            About = true;
            #endregion
        }

        #region HP Mana Flask Menu
        [Menu("HP/MANA % Auto Flask", 10)]
        public ToggleNode AutoFlask { get; set; }
        [Menu("Min Life % Auto HP Flask", 11, 10)]
        public RangeNode<int> PerHpFlask { get; set; }
        [Menu("Min Life % Auto Instant HP Flask (put instant flask in last slot)", 12, 10)]
        public RangeNode<int> InstantPerHpFlask { get; set; }

        [Menu("Min Mana % Auto Mana Flask", 14, 10)]
        public RangeNode<float> PerManaFlask { get; set; }
        [Menu("Min Mana Auto Mana Flask", 15, 10)]
        public RangeNode<float> MinManaFlask { get; set; }
		[Menu("Min Mana % Auto Instant HP Flask (put instant flask in last slot)", 16, 10)]
        public RangeNode<int> InstantPerMpFlask { get; set; }
        [Menu("Disable Life/Hybrid Flask Offensive/Defensive Usage", 18, 10)]
        public ToggleNode DisableLifeSecUse { get; set; }
        #endregion

        #region Ailment Flask Menu
        [Menu("Remove Ailment Flask", 20)]
        public ToggleNode RemAilment { get; set; }
        [Menu("Remove Frozen", 21, 20)]
        public ToggleNode RemFrozen { get; set; }
        [Menu("Remove Burning", 22, 20)]
        public ToggleNode RemBurning { get; set; }
        [Menu("Remove Shocked", 23, 20)]
        public ToggleNode RemShocked { get; set; }
        [Menu("Remove Curse", 24, 20)]
        public ToggleNode RemCurse { get; set; }
        [Menu("Remove Poison", 25, 20)]
        public ToggleNode RemPoison { get; set; }
        [Menu("Remove Corrupting/Bleed", 26, 20)]
        public ToggleNode RemBleed { get; set; }
        [Menu("Corrupting Blood Stacks", 27, 20)]
        public RangeNode<int> CorrptCount { get; set; }
        [Menu("Remove Ailment Post Duration (millisecond)", 28, 20)]
        public RangeNode<int> AilmentDur { get; set; }
        #endregion

        #region Speed Flask Menu
		[Menu("Speed Flask", 30)]
        public ToggleNode SpeedFlaskEnable { get; set; }

        [Menu("QuickSilver Flask", 31, 30)]
        public ToggleNode QuicksilverEnable { get; set; }
        [Menu("Use QuickSilver After Moving Post (millisecond)", 32, 30)]
        public RangeNode<float> QuicksilverDurration { get; set; }
        [Menu("Use QuickSilver When Charges Greater than X (0 to disable it)", 33, 30)]
        public RangeNode<int> QuicksilverUseWhenCharges { get; set; }

        [Menu("Silver Flask", 34, 30)]
        public ToggleNode SilverFlaskEnable { get; set; }
        [Menu("Use Silver Flask After Moving Post (millisecond)", 35, 30)]
        public RangeNode<float> SilverFlaskDurration { get; set; }
        [Menu("Use Silver Flask When Charges Greater than X (0 to disable it)", 36, 30)]
        public RangeNode<int> SilverFlaskUseWhenCharges { get; set; }
        [Menu("Drink Silver/QuickSilver Together", 37, 30)]
        public ToggleNode ShouldDrinkSilverQuickSilverTogether { get; set; }
        #endregion
			
        #region Defensive Flask Menu
        [Menu("Defensive Flask", 40)]
        public ToggleNode DefFlaskEnable { get; set; }
        [Menu("Min Life %", 41, 40)]
        public RangeNode<int> HpDefensive { get; set; }
        [Menu("Min ES %", 42, 40)]
        public RangeNode<int> EsDefensive { get; set; }
        [Menu("Delay (millisecond)", 43, 40)]
        public RangeNode<float> DefensiveDelay { get; set; }
        [Menu("Treat Offensive Flasks As Defensive", 44, 40)]
        public ToggleNode TreatOffenAsDef { get; set; }
        [Menu("Drink All Flasks Together", 45, 40)]
        public ToggleNode DefensiveDrinkAll { get; set; }
        #endregion

        #region Offensive Flask Menu
        [Menu("Offensive Flask", 50)]
        public ToggleNode OffFlaskEnable { get; set; }
        [Menu("Drink On Life/ES", 51, 50)]
        public ToggleNode OffensiveWhenLifeEs { get; set; }
        [Menu("Min Life %", 52, 51)]
        public RangeNode<int> HpOffensive { get; set; }
        [Menu("Min ES %", 53, 51)]
        public RangeNode<int> EsOffensive { get; set; }
        [Menu("Drink On Skill Use", 54, 50)]
        public ToggleNode OffensiveWhenAttacking { get; set; }
        [Menu("Drink On Key Use", 55, 50)]
        public ToggleNode UseWhileKeyPressed { get; set; }
        [Menu("Skill Key Hotkey", 56, 50)]
        public HotkeyNode KeyPressed { get; set; }
        [Menu("Delay (millisecond)", 57, 50)]
        public RangeNode<float> OffensiveDelay { get; set; }
        [Menu("Use When Charges Greater than X (0 to disable it)", 58, 50)]
        public RangeNode<int> OffensiveUseWhenCharges { get; set; }
        [Menu("Drink All Flasks Together", 59, 50)]
        public ToggleNode OffensiveDrinkAll { get; set; }
        #endregion

        #region Unnique Flask Menu
        [Menu("Unique Flask", 60)]
        public ToggleNode UniqFlaskEnable { get; set; }
        #endregion
        #region Vaal Haste Menu
        [Menu("Vaal Haste", 68)]
        public ToggleNode VaalHasteEnable { get; set; }
        [Menu("Skill Key Hotkey", 69, 68)]
        public HotkeyNode HasteUseKey { get; set; }
        #endregion
        #region Defensive Skill Menu
        [Menu("Defensive Skill", 70)]
        public ToggleNode DefSkillEnable { get; set; }
        [Menu("Min Life %", 71, 70)]
        public RangeNode<int> HpDefensiveSkill { get; set; }
        [Menu("Min ES %", 72, 70)]
        public RangeNode<int> EsDefensiveSkill { get; set; }
        [Menu("Delay (millisecond)", 73, 70)]
        public RangeNode<float> DefensiveSkillDelay { get; set; }
        [Menu("Skill Key Hotkey", 74, 70)]
        public HotkeyNode SkillUseKey { get; set; }
        #endregion
        #region Defensive Skill 2 Menu
        [Menu("Defensive Skill 2", 75)]
        public ToggleNode DefSkillEnable2 { get; set; }
        [Menu("Min Life %", 76, 75)]
        public RangeNode<int> HpDefensiveSkill2 { get; set; }
        [Menu("Min ES %", 77, 75)]
        public RangeNode<int> EsDefensiveSkill2 { get; set; }
        [Menu("Delay (millisecond)", 78, 75)]
        public RangeNode<float> DefensiveSkillDelay2 { get; set; }
        [Menu("Skill Key Hotkey", 79, 75)]
        public HotkeyNode SkillUseKey2 { get; set; }
        #endregion

        #region Movement Skill Menu
        [Menu("Movement Skill", 80)]
        public ToggleNode MoveEnable { get; set; }
        [Menu("Use After Moving Post (millisecond)", 81, 80)]
        public RangeNode<float> MoveDurration { get; set; }
        [Menu("Skill Key Hotkey", 82, 80)]
        public HotkeyNode MoveUseKey { get; set; }
        [Menu("Hold shift", 83, 80)]
        public ToggleNode ShiftMod { get; set; }
        //[Menu("Delay (millisecond)", 83, 80)]
        //public RangeNode<float> MoveSkillDelay { get; set; }
        #endregion

        #region Recastables Menu
        [Menu("Recastable Skills", 90)]
        public ToggleNode RecastableEnable { get; set; }
        [Menu("Golems", 91, 90)]
        public ToggleNode GolemsEnable { get; set; }
        [Menu("Fire Golem", 92, 91)]
        public ToggleNode FireElEnable { get; set; }
        [Menu("Skill Key Hotkey", 93, 91)]
        public HotkeyNode FireElKey { get; set; }
        [Menu("Lightning Golem", 94, 91)]
        public ToggleNode LightningElEnable { get; set; }
        [Menu("Skill Key Hotkey", 95, 91)]
        public HotkeyNode LightningElKey { get; set; }
        [Menu("Stone Golem", 96, 91)]
        public ToggleNode RockElEnable { get; set; }
        [Menu("Skill Key Hotkey", 97, 91)]
        public HotkeyNode RockElKey { get; set; }
        [Menu("Ice Golem", 98, 91)]
        public ToggleNode IceElEnable { get; set; }
        [Menu("Skill Key Hotkey", 99, 91)]
        public HotkeyNode IceElKey { get; set; }
        [Menu("Chaos Golem", 100, 91)]
        public ToggleNode ChaosElEnable { get; set; }
        [Menu("Skill Key Hotkey", 101, 91)]
        public HotkeyNode ChaosElKey { get; set; }
        [Menu("Buffs", 102, 90)]
        public ToggleNode BuffsEnable { get; set; }
        [Menu("Blood Rage On Buff Timing out", 103, 102)]
        public ToggleNode BloodRageEnable { get; set; }
        [Menu("Skill Key Hotkey", 104, 102)]
        public HotkeyNode BloodRageKey { get; set; }
        [Menu("Blood Rage Expires In...", 105, 102)]
        public RangeNode<float> BRTime { get; set; }
        [Menu("Enduring Cry On Charges Timing out", 106, 102)]
        public ToggleNode EndurChargeEnable { get; set; }
        [Menu("Enduring Cry Hotkey", 107, 102)]
        public HotkeyNode EndurCryKey { get; set; }
        [Menu("Endurance Charges Expires In...", 108, 102)]
        public RangeNode<float> ECTime { get; set; }
        #endregion

        #region Settings Menu
        [Menu("UI Settings", 200)]
        public EmptyNode UiSesettingsHolder { get; set; }
        [Menu("Flask Slot UI", 201, 200)]

        public ToggleNode FlaskUiEnable { get; set; }
        [Menu("Position: X", 202, 201)]
        public RangeNode<float> FlaskPositionX { get; set; }
        [Menu("Position: Y", 203, 201)]
        public RangeNode<float> FlaskPositionY { get; set; }
        [Menu("Text Size", 204, 201)]
        public RangeNode<int> FlaskTextSize { get; set; }

        [Menu("Buff Bar UI", 205, 200)]
        public ToggleNode BuffUiEnable { get; set; }
        [Menu("Position: X", 206, 205)]
        public RangeNode<float> BuffPositionX { get; set; }
        [Menu("Position: Y", 207, 205)]
        public RangeNode<float> BuffPositionY { get; set; }
        [Menu("Text Size", 208, 205)]
        public RangeNode<int> BuffTextSize { get; set; }
        [Menu("Enable Flask Or Aura Debuff/Buff", 209, 205)]
        public ToggleNode EnableFlaskAuraBuff { get; set; }

        [Menu("Debug Mode", 210, 200)]
        public ToggleNode DebugMode { get; set; }

        [Menu("Enable/Disable Flasks", 220)]
        public EmptyNode FlasksettingsHolder { get; set; }
        [Menu("Use Flask Slot 1", 221, 220)]
        public ToggleNode FlaskSlot1Enable { get; set; }
        [Menu("Use Flask Slot 2", 222, 220)]
        public ToggleNode FlaskSlot2Enable { get; set; }
        [Menu("Use Flask Slot 3", 223, 220)]
        public ToggleNode FlaskSlot3Enable { get; set; }
        [Menu("Use Flask Slot 4", 224, 220)]
        public ToggleNode FlaskSlot4Enable { get; set; }
        [Menu("Use Flask Slot 5", 225, 220)]
        public ToggleNode FlaskSlot5Enable { get; set; }

        [Menu("About", 226)]
        public ToggleNode About { get; set; }

        [Menu("Total Charges Reduction %", 227)]
        public RangeNode<float> ChargeReduction { get; set; }
        #endregion

    }
}
