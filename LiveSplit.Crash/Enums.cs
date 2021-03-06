﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit.Crash
{
	public enum ColoredGems
	{
		Red,
		Blue,
		Green,
		Orange,
		Yellow,
		Purple,
		None
	}

	public enum Categories
	{
		AnyPercent,
		AllGems,
		OneHundredPercent,
		OneOhTwoPercent,
		OneOhFivePercent,
		OneOhEightPercent,
		TrilogyAnyPercent,
		TrilogyThreeFifteenPercent,
		Unknown
	}
	
	public enum Stages
	{
		//---------//
		// Crash 1 //
		//---------//

		// Island 1
		NSanityBeach,
		JungleRollers,
		TheGreatGate,
		Boulders,
		Upstream,
		RollingStones,
		HogWild,
		NativeFortress,

		// Island 2
		UpTheCreek,
		TheLostCity,
		TempleRuins,
		RoadToNowhere,
		BoulderDash,
		WholeHog,
		SunsetVista,

		// Island 3
		HeavyMachinery,
		CortexPower,
		GeneratorRoom,
		ToxicWaste,
		TheHighRoad,
		SlipperyClimb,
		LightsOut,
		FumblingInTheDark,
		JawsOfDarkness,
		CastleMachinery,
		TheLab,

		// Bosses
		PapuPapu,
		KoalaKong,
		PinstripePotoroo,
		DrNitrusBrio,

		// Other
		TheGreatHall,

		// DLC
		StormyAscent,

		//---------//
		// Crash 2 //
		//---------//

		// Chamber 1
		TurtleWoods,
		SnowGo,
		HangEight,
		ThePits,
		CrashDash,

		// Chamber 2
		AirCrash,
		SnowBiz,
		BearIt,
		CrashCrush,
		TheEelDeal,

		// Chamber 3
		PlantFood,
		SewerOrLater,
		BearDown,
		RoadToRuin,
		UnBearable,

		// Chamber 4
		HanginOut,
		DigginIt,
		ColdHardCrash,
		Ruination,
		BeeHaving,

		// Chamber 5
		PistonItAway,
		RockIt,
		NightFight,
		PackAttack,
		SpacedOut,

		// Secret stages
		TotallyBear,
		TotallyFly,

		// Bosses
		KomodoBrothers,

		//---------//
		// Crash 3 //
		//---------//

		// Warp 1
		ToadVillage,
		UnderPressure,
		OrientExpress,
		BoneYard,
		MakinWaves,

		// Warp 2
		GeeWiz,
		HangEmHigh,
		HogRide,
		TombTime,
		MidnightRun,

		// Warp 3
		DinoMight,
		DeepTrouble,
		HighTime,
		RoadCrash,
		DoubleHeader,

		// Warp 4
		Sphynxinator,
		ByeByeBlimps,
		TellNoTales,
		FutureFrenzy,
		TombWader,

		// Warp 5
		GoneTomorrow,
		OrangeAsphalt,
		FlamingPassion,
		MadBombers,
		BugLite,

		// Warp 6
		SkiCrazed,
		Area51,
		RingsOfPower,

		// Secret stages
		HotCoco,
		EggipusRex,

		// Bosses
		Dingodile,
		DrNTropy,

		// DLC
		FutureTense,

		//-----------------//
		// Repeated bosses //
		//-----------------//
		RipperRoo,
		TinyTiger,
		DrNGin,
		DrNeoCortex,

		//------//
		// Hubs //
		//------//

		TheWumpaIslands,
		NSanityIsland,
		CortexIsland,
		TheWarpRoom,
		TheTimeTwister
	}
}
