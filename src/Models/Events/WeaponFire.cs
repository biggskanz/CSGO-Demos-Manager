﻿using Newtonsoft.Json;

namespace CSGO_Demos_Manager.Models.Events
{
	public class WeaponFire : BaseEvent
	{
		[JsonIgnore]
		public HeatmapPoint Point { get; set; }

		[JsonProperty("shooter_steamid")]
		public long ShooterSteamId { get; set; }

		[JsonProperty("shooter_name")]
		public string ShooterName { get; set; }

		[JsonProperty("weapon")]
		public Weapon Weapon { get; set; }

		[JsonProperty("round_number")]
		public int RoundNumber { get; set; }

		[JsonProperty("shooter_vel_x")]
		public float ShooterVelocityX { get; set; }

		[JsonProperty("shooter_vel_y")]
		public float ShooterVelocityY { get; set; }

		[JsonProperty("shooter_vel_z")]
		public float ShooterVelocityZ { get; set; }

		[JsonIgnore]
		public override string Message => ShooterName + " throwed " + Weapon.Name;

		public WeaponFire(int tick) : base(tick) { }
	}
}
