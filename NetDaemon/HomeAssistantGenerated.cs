using System;
using System.Collections.Generic;
using NetDaemon.HassModel;
using NetDaemon.HassModel.Entities;
using NetDaemon.HassModel.Entities.Core;
using System.Text.Json.Serialization;

namespace HomeAssistantGenerated
{
	public interface IEntities
	{
		AutomationEntities Automation { get; }

		BinarySensorEntities BinarySensor { get; }

		ButtonEntities Button { get; }

		CameraEntities Camera { get; }

		CoverEntities Cover { get; }

		DeviceTrackerEntities DeviceTracker { get; }

		FanEntities Fan { get; }

		InputBooleanEntities InputBoolean { get; }

		InputDatetimeEntities InputDatetime { get; }

		InputNumberEntities InputNumber { get; }

		LightEntities Light { get; }

		MediaPlayerEntities MediaPlayer { get; }

		NumberEntities Number { get; }

		PersonEntities Person { get; }

		SceneEntities Scene { get; }

		ScriptEntities Script { get; }

		SelectEntities Select { get; }

		SensorEntities Sensor { get; }

		SunEntities Sun { get; }

		SwitchEntities Switch { get; }

		UpdateEntities Update { get; }

		WeatherEntities Weather { get; }

		ZoneEntities Zone { get; }
	}

	public partial class Entities : IEntities
	{
		private readonly IHaContext _haContext;
		public Entities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AutomationEntities Automation => new(_haContext);
		public BinarySensorEntities BinarySensor => new(_haContext);
		public ButtonEntities Button => new(_haContext);
		public CameraEntities Camera => new(_haContext);
		public CoverEntities Cover => new(_haContext);
		public DeviceTrackerEntities DeviceTracker => new(_haContext);
		public FanEntities Fan => new(_haContext);
		public InputBooleanEntities InputBoolean => new(_haContext);
		public InputDatetimeEntities InputDatetime => new(_haContext);
		public InputNumberEntities InputNumber => new(_haContext);
		public LightEntities Light => new(_haContext);
		public MediaPlayerEntities MediaPlayer => new(_haContext);
		public NumberEntities Number => new(_haContext);
		public PersonEntities Person => new(_haContext);
		public SceneEntities Scene => new(_haContext);
		public ScriptEntities Script => new(_haContext);
		public SelectEntities Select => new(_haContext);
		public SensorEntities Sensor => new(_haContext);
		public SunEntities Sun => new(_haContext);
		public SwitchEntities Switch => new(_haContext);
		public UpdateEntities Update => new(_haContext);
		public WeatherEntities Weather => new(_haContext);
		public ZoneEntities Zone => new(_haContext);
	}

	public partial class AutomationEntities
	{
		private readonly IHaContext _haContext;
		public AutomationEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Blinds Close</summary>
		public AutomationEntity BlindsClose => new(_haContext, "automation.blinds_close");
		///<summary>Blinds Open</summary>
		public AutomationEntity BlindsOpen => new(_haContext, "automation.blinds_open");
		///<summary>Filter Notification</summary>
		public AutomationEntity FilterNotification => new(_haContext, "automation.filter_notification");
		///<summary>Garage Close</summary>
		public AutomationEntity GarageClose => new(_haContext, "automation.garage_close");
		///<summary>Garage Open</summary>
		public AutomationEntity GarageOpen => new(_haContext, "automation.garage_open");
		///<summary>Kitchen Cover Control</summary>
		public AutomationEntity KitchenCoverControl => new(_haContext, "automation.kitchen_cover_control");
		///<summary>Living Room Cover Control</summary>
		public AutomationEntity LivingRoomCoverControl => new(_haContext, "automation.living_room_cover_control");
		///<summary>Living Room Remote</summary>
		public AutomationEntity LivingRoomRemote => new(_haContext, "automation.living_room_remote");
		///<summary>Modem Keep On</summary>
		public AutomationEntity ModemKeepOn => new(_haContext, "automation.modem_keep_on");
		///<summary>Morning</summary>
		public AutomationEntity Morning => new(_haContext, "automation.morning");
		///<summary>Salt Level Notification</summary>
		public AutomationEntity SaltLevelNotification => new(_haContext, "automation.salt_level_notification");
		///<summary>Set Theme</summary>
		public AutomationEntity SetTheme => new(_haContext, "automation.set_theme");
	}

	public partial class BinarySensorEntities
	{
		private readonly IHaContext _haContext;
		public BinarySensorEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Garage Door MyQ Gateway</summary>
		public BinarySensorEntity GarageDoorMyqGateway => new(_haContext, "binary_sensor.garage_door_myq_gateway");
		///<summary>Sensor</summary>
		public BinarySensorEntity Homespy0 => new(_haContext, "binary_sensor.homespy_0");
		///<summary>Sensor</summary>
		public BinarySensorEntity Homespy1 => new(_haContext, "binary_sensor.homespy_1");
		///<summary>Sensor</summary>
		public BinarySensorEntity Homespy10 => new(_haContext, "binary_sensor.homespy_10");
		///<summary>Sensor</summary>
		public BinarySensorEntity Homespy11 => new(_haContext, "binary_sensor.homespy_11");
		///<summary>Sensor</summary>
		public BinarySensorEntity Homespy12 => new(_haContext, "binary_sensor.homespy_12");
		///<summary>Sensor</summary>
		public BinarySensorEntity Homespy13 => new(_haContext, "binary_sensor.homespy_13");
		///<summary>Sensor</summary>
		public BinarySensorEntity Homespy14 => new(_haContext, "binary_sensor.homespy_14");
		///<summary>Sensor</summary>
		public BinarySensorEntity Homespy15 => new(_haContext, "binary_sensor.homespy_15");
		///<summary>Sensor</summary>
		public BinarySensorEntity Homespy2 => new(_haContext, "binary_sensor.homespy_2");
		///<summary>Sensor</summary>
		public BinarySensorEntity Homespy3 => new(_haContext, "binary_sensor.homespy_3");
		///<summary>Sensor</summary>
		public BinarySensorEntity Homespy4 => new(_haContext, "binary_sensor.homespy_4");
		///<summary>Sensor</summary>
		public BinarySensorEntity Homespy5 => new(_haContext, "binary_sensor.homespy_5");
		///<summary>Sensor</summary>
		public BinarySensorEntity Homespy6 => new(_haContext, "binary_sensor.homespy_6");
		///<summary>Sensor</summary>
		public BinarySensorEntity Homespy7 => new(_haContext, "binary_sensor.homespy_7");
		///<summary>Sensor</summary>
		public BinarySensorEntity Homespy8 => new(_haContext, "binary_sensor.homespy_8");
		///<summary>Sensor</summary>
		public BinarySensorEntity Homespy9 => new(_haContext, "binary_sensor.homespy_9");
		///<summary>Leak Sump</summary>
		public BinarySensorEntity LeakSump => new(_haContext, "binary_sensor.leak_sump");
		///<summary>Leak Water Main</summary>
		public BinarySensorEntity LeakWaterMain => new(_haContext, "binary_sensor.leak_water_main");
		///<summary>Leak Window East</summary>
		public BinarySensorEntity LeakWindowEast => new(_haContext, "binary_sensor.leak_window_east");
		///<summary>Leak Window North</summary>
		public BinarySensorEntity LeakWindowNorth => new(_haContext, "binary_sensor.leak_window_north");
		///<summary>Pi-Hole</summary>
		public BinarySensorEntity PiHole => new(_haContext, "binary_sensor.pi_hole");
		///<summary>Pi-Hole Core Update Available</summary>
		public BinarySensorEntity PiHoleCoreUpdateAvailable => new(_haContext, "binary_sensor.pi_hole_core_update_available");
		///<summary>Pi-Hole FTL Update Available</summary>
		public BinarySensorEntity PiHoleFtlUpdateAvailable => new(_haContext, "binary_sensor.pi_hole_ftl_update_available");
		///<summary>Pi-Hole Web Update Available</summary>
		public BinarySensorEntity PiHoleWebUpdateAvailable => new(_haContext, "binary_sensor.pi_hole_web_update_available");
		///<summary>Pixel 6 Pro Is Charging</summary>
		public BinarySensorEntity Pixel6ProIsCharging => new(_haContext, "binary_sensor.pixel_6_pro_is_charging");
		///<summary>RBR20 (Gateway) wan status</summary>
		public BinarySensorEntity Rbr20GatewayWanStatus => new(_haContext, "binary_sensor.rbr20_gateway_wan_status");
		///<summary>Remote UI</summary>
		public BinarySensorEntity RemoteUi => new(_haContext, "binary_sensor.remote_ui");
		///<summary>SM-G973U Is Charging</summary>
		public BinarySensorEntity SmG973uIsCharging => new(_haContext, "binary_sensor.sm_g973u_is_charging");
		///<summary>Updater</summary>
		public BinarySensorEntity Updater => new(_haContext, "binary_sensor.updater");
	}

	public partial class ButtonEntities
	{
		private readonly IHaContext _haContext;
		public ButtonEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Caséta® Wireless Fan Speed Control Identify</summary>
		public ButtonEntity CasetaRWirelessFanSpeedControlIdentify => new(_haContext, "button.caseta_r_wireless_fan_speed_control_identify");
		///<summary>Caséta® Wireless Fan Speed Control Identify</summary>
		public ButtonEntity CasetaRWirelessFanSpeedControlIdentify2 => new(_haContext, "button.caseta_r_wireless_fan_speed_control_identify_2");
		///<summary>Caséta® Wireless In-wall Dimmer Identify</summary>
		public ButtonEntity CasetaRWirelessInWallDimmerIdentify => new(_haContext, "button.caseta_r_wireless_in_wall_dimmer_identify");
		///<summary>IKEA of Sweden TRADFRI bulb E26 CWS opal 600lm 1475bafe identify</summary>
		public ButtonEntity IkeaOfSwedenTradfriBulbE26CwsOpal600lm1475bafeIdentify => new(_haContext, "button.ikea_of_sweden_tradfri_bulb_e26_cws_opal_600lm_1475bafe_identify");
		///<summary>IKEA of Sweden TRADFRI bulb E26 CWS opal 600lm 218326fe identify</summary>
		public ButtonEntity IkeaOfSwedenTradfriBulbE26CwsOpal600lm218326feIdentify => new(_haContext, "button.ikea_of_sweden_tradfri_bulb_e26_cws_opal_600lm_218326fe_identify");
		///<summary>IKEA of Sweden TRADFRI Signal Repeater 6c33d5fe identify</summary>
		public ButtonEntity IkeaOfSwedenTradfriSignalRepeater6c33d5feIdentify => new(_haContext, "button.ikea_of_sweden_tradfri_signal_repeater_6c33d5fe_identify");
		///<summary>IKEA of Sweden TRADFRI Signal Repeater c130d5fe identify</summary>
		public ButtonEntity IkeaOfSwedenTradfriSignalRepeaterC130d5feIdentify => new(_haContext, "button.ikea_of_sweden_tradfri_signal_repeater_c130d5fe_identify");
		///<summary>IKEA of Sweden TRADFRI signal repeater df98ddfe identify</summary>
		public ButtonEntity IkeaOfSwedenTradfriSignalRepeaterDf98ddfeIdentify => new(_haContext, "button.ikea_of_sweden_tradfri_signal_repeater_df98ddfe_identify");
		///<summary>LUMI lumi.sensor_wleak.aq1 603d3306 identify</summary>
		public ButtonEntity LumiLumiSensorWleakAq1603d3306Identify => new(_haContext, "button.lumi_lumi_sensor_wleak_aq1_603d3306_identify");
		///<summary>LUMI lumi.sensor_wleak.aq1 98a13506 identify</summary>
		public ButtonEntity LumiLumiSensorWleakAq198a13506Identify => new(_haContext, "button.lumi_lumi_sensor_wleak_aq1_98a13506_identify");
		///<summary>LUMI lumi.sensor_wleak.aq1 aeb53306 identify</summary>
		public ButtonEntity LumiLumiSensorWleakAq1Aeb53306Identify => new(_haContext, "button.lumi_lumi_sensor_wleak_aq1_aeb53306_identify");
		///<summary>LUMI lumi.sensor_wleak.aq1 cd333306 identify</summary>
		public ButtonEntity LumiLumiSensorWleakAq1Cd333306Identify => new(_haContext, "button.lumi_lumi_sensor_wleak_aq1_cd333306_identify");
		///<summary>LUMI lumi.weather 204a7906 identify</summary>
		public ButtonEntity LumiLumiWeather204a7906Identify => new(_haContext, "button.lumi_lumi_weather_204a7906_identify");
		///<summary>LUMI lumi.weather 2566d701 identify</summary>
		public ButtonEntity LumiLumiWeather2566d701Identify => new(_haContext, "button.lumi_lumi_weather_2566d701_identify");
		///<summary>LUMI lumi.weather b3967f05 identify</summary>
		public ButtonEntity LumiLumiWeatherB3967f05Identify => new(_haContext, "button.lumi_lumi_weather_b3967f05_identify");
		///<summary>LUMI lumi.weather d99a8205 identify</summary>
		public ButtonEntity LumiLumiWeatherD99a8205Identify => new(_haContext, "button.lumi_lumi_weather_d99a8205_identify");
		///<summary>LUMI lumi.weather f7e97806 identify</summary>
		public ButtonEntity LumiLumiWeatherF7e97806Identify => new(_haContext, "button.lumi_lumi_weather_f7e97806_identify");
		///<summary>Node 2: Ping</summary>
		public ButtonEntity Node2Ping => new(_haContext, "button.node_2_ping");
		///<summary>Philips LCT016 a7248e03 identify</summary>
		public ButtonEntity PhilipsLct016A7248e03Identify => new(_haContext, "button.philips_lct016_a7248e03_identify");
		///<summary>Smart Bridge 2 Identify</summary>
		public ButtonEntity SmartBridge2Identify => new(_haContext, "button.smart_bridge_2_identify");
	}

	public partial class CameraEntities
	{
		private readonly IHaContext _haContext;
		public CameraEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>IND</summary>
		public CameraEntity Ind => new(_haContext, "camera.ind");
	}

	public partial class CoverEntities
	{
		private readonly IHaContext _haContext;
		public CoverEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Breakfast Center</summary>
		public CoverEntity BreakfastCenter => new(_haContext, "cover.breakfast_center");
		///<summary>Breakfast Left</summary>
		public CoverEntity BreakfastLeft => new(_haContext, "cover.breakfast_left");
		///<summary>Breakfast Right</summary>
		public CoverEntity BreakfastRight => new(_haContext, "cover.breakfast_right");
		///<summary>Garage Door</summary>
		public CoverEntity GarageDoor => new(_haContext, "cover.garage_door");
		///<summary>Kitchen Shades</summary>
		public CoverEntity KitchenShades => new(_haContext, "cover.kitchen_shades");
		///<summary>Living Room Right</summary>
		public CoverEntity LivingRoomRight => new(_haContext, "cover.living_room_right");
		///<summary>Living Room Shades</summary>
		public CoverEntity LivingRoomShades => new(_haContext, "cover.living_room_shades");
		///<summary>Living Room Left</summary>
		public CoverEntity TradfriBlind4 => new(_haContext, "cover.tradfri_blind_4");
		///<summary>Living Room Center</summary>
		public CoverEntity TradfriBlind6 => new(_haContext, "cover.tradfri_blind_6");
	}

	public partial class DeviceTrackerEntities
	{
		private readonly IHaContext _haContext;
		public DeviceTrackerEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Pixel 6 Pro</summary>
		public DeviceTrackerEntity Pixel6Pro => new(_haContext, "device_tracker.pixel_6_pro");
		///<summary>SM-G973U</summary>
		public DeviceTrackerEntity SmG973u => new(_haContext, "device_tracker.sm_g973u");
	}

	public partial class FanEntities
	{
		private readonly IHaContext _haContext;
		public FanEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Bedroom Fan</summary>
		public FanEntity Bedroom => new(_haContext, "fan.bedroom");
		///<summary>Master Bedroom Ceiling Fan</summary>
		public FanEntity MasterBedroomCeilingFan => new(_haContext, "fan.master_bedroom_ceiling_fan");
		///<summary>Office Fan</summary>
		public FanEntity Office => new(_haContext, "fan.office");
		///<summary>Office Ceiling Fan</summary>
		public FanEntity OfficeCeilingFan => new(_haContext, "fan.office_ceiling_fan");
	}

	public partial class InputBooleanEntities
	{
		private readonly IHaContext _haContext;
		public InputBooleanEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Bedroom 1 Occupied</summary>
		public InputBooleanEntity Bedroom1Occupied => new(_haContext, "input_boolean.bedroom_1_occupied");
		///<summary>Bedroom 2 Occupied</summary>
		public InputBooleanEntity Bedroom2Occupied => new(_haContext, "input_boolean.bedroom_2_occupied");
		///<summary>Bedroom M Occupied</summary>
		public InputBooleanEntity BedroomMOccupied => new(_haContext, "input_boolean.bedroom_m_occupied");
		///<summary>netdaemon_net_daemon_wrapper_context</summary>
		public InputBooleanEntity NetdaemonNetDaemonWrapperContext => new(_haContext, "input_boolean.netdaemon_net_daemon_wrapper_context");
		///<summary>netdaemon_net_daemon_wrapper_event_state_change_action_init</summary>
		public InputBooleanEntity NetdaemonNetDaemonWrapperEventStateChangeActionInit => new(_haContext, "input_boolean.netdaemon_net_daemon_wrapper_event_state_change_action_init");
		///<summary>netdaemon_net_daemon_wrapper_lighting_light_manager</summary>
		public InputBooleanEntity NetdaemonNetDaemonWrapperLightingLightManager => new(_haContext, "input_boolean.netdaemon_net_daemon_wrapper_lighting_light_manager");
		///<summary>netdaemon_net_daemon_wrapper_scene_scenes</summary>
		public InputBooleanEntity NetdaemonNetDaemonWrapperSceneScenes => new(_haContext, "input_boolean.netdaemon_net_daemon_wrapper_scene_scenes");
		///<summary>Office Occupied</summary>
		public InputBooleanEntity OfficeOccupied => new(_haContext, "input_boolean.office_occupied");
	}

	public partial class InputDatetimeEntities
	{
		private readonly IHaContext _haContext;
		public InputDatetimeEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Bed Time</summary>
		public InputDatetimeEntity BedTime => new(_haContext, "input_datetime.bed_time");
		///<summary>Work Time</summary>
		public InputDatetimeEntity WorkTime => new(_haContext, "input_datetime.work_time");
	}

	public partial class InputNumberEntities
	{
		private readonly IHaContext _haContext;
		public InputNumberEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Bedroom Evening Target</summary>
		public InputNumberEntity BedroomEveningTarget => new(_haContext, "input_number.bedroom_evening_target");
		///<summary>Bedroom Current Target</summary>
		public InputNumberEntity BedroomTargetCurrent => new(_haContext, "input_number.bedroom_target_current");
		///<summary>Bedroom Day Target</summary>
		public InputNumberEntity BedroomTargetDay => new(_haContext, "input_number.bedroom_target_day");
		///<summary>Bedroom Morning Target</summary>
		public InputNumberEntity BedroomTargetMorning => new(_haContext, "input_number.bedroom_target_morning");
		///<summary>Office Target</summary>
		public InputNumberEntity OfficeTarget => new(_haContext, "input_number.office_target");
	}

	public partial class LightEntities
	{
		private readonly IHaContext _haContext;
		public LightEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Bedroom Ceiling</summary>
		public LightEntity BedroomCeiling => new(_haContext, "light.bedroom_ceiling");
		///<summary>Bedroom Fan</summary>
		public LightEntity BedroomFan => new(_haContext, "light.bedroom_fan");
		///<summary>Breakfast</summary>
		public LightEntity Breakfast => new(_haContext, "light.breakfast");
		///<summary>Ceiling</summary>
		public LightEntity Ceiling => new(_haContext, "light.ceiling");
		///<summary>Dining Room</summary>
		public LightEntity DiningRoom => new(_haContext, "light.dining_room");
		///<summary>Entry</summary>
		public LightEntity Entry => new(_haContext, "light.entry");
		///<summary>Hall Overlook</summary>
		public LightEntity HallOverlook => new(_haContext, "light.hall_overlook");
		///<summary>Hall Stair</summary>
		public LightEntity HallStair => new(_haContext, "light.hall_stair");
		///<summary>Living Room Corner</summary>
		public LightEntity HueColorLamp42 => new(_haContext, "light.hue_color_lamp_4_2");
		///<summary>Living Room Floor</summary>
		public LightEntity HueColorLamp43 => new(_haContext, "light.hue_color_lamp_4_3");
		///<summary>IKEA of Sweden TRADFRI bulb E26 CWS opal 600lm 1475bafe level, light_color, on_off</summary>
		public LightEntity IkeaOfSwedenTradfriBulbE26CwsOpal600lm1475bafeLevelLightColorOnOff => new(_haContext, "light.ikea_of_sweden_tradfri_bulb_e26_cws_opal_600lm_1475bafe_level_light_color_on_off");
		///<summary>IKEA of Sweden TRADFRI bulb E26 CWS opal 600lm 218326fe level, light_color, on_off</summary>
		public LightEntity IkeaOfSwedenTradfriBulbE26CwsOpal600lm218326feLevelLightColorOnOff => new(_haContext, "light.ikea_of_sweden_tradfri_bulb_e26_cws_opal_600lm_218326fe_level_light_color_on_off");
		///<summary>Kitchen 1</summary>
		public LightEntity Island1 => new(_haContext, "light.island_1");
		///<summary>Island 2</summary>
		public LightEntity Island2 => new(_haContext, "light.island_2");
		///<summary>Island 3</summary>
		public LightEntity Island3 => new(_haContext, "light.island_3");
		///<summary>Island 4</summary>
		public LightEntity Island4 => new(_haContext, "light.island_4");
		///<summary>Living Floor 1</summary>
		public LightEntity LrFloor1 => new(_haContext, "light.lr_floor_1");
		///<summary>Living Floor 2</summary>
		public LightEntity LrFloor2 => new(_haContext, "light.lr_floor_2");
		///<summary>Living Floor 3</summary>
		public LightEntity LrFloor3 => new(_haContext, "light.lr_floor_3");
		///<summary>Nightstand R</summary>
		public LightEntity NightstandR => new(_haContext, "light.nightstand_r");
		///<summary>Office Lights</summary>
		public LightEntity Office => new(_haContext, "light.office");
		///<summary>Office Main Lights</summary>
		public LightEntity OfficeMainLights => new(_haContext, "light.office_main_lights");
		///<summary>Philips LCT016 a7248e03 level, light_color, on_off</summary>
		public LightEntity PhilipsLct016A7248e03LevelLightColorOnOff => new(_haContext, "light.philips_lct016_a7248e03_level_light_color_on_off");
		///<summary>Pole</summary>
		public LightEntity Pole => new(_haContext, "light.pole");
		///<summary>Sign</summary>
		public LightEntity Sign => new(_haContext, "light.sign");
		///<summary>Sink</summary>
		public LightEntity Sink => new(_haContext, "light.sink");
		///<summary>Stair 1</summary>
		public LightEntity Stair1 => new(_haContext, "light.stair_1");
		///<summary>Stair 2</summary>
		public LightEntity Stair2 => new(_haContext, "light.stair_2");
		///<summary>Studio Down</summary>
		public LightEntity StudioDown => new(_haContext, "light.studio_down");
		///<summary>Studio Up</summary>
		public LightEntity StudioUp => new(_haContext, "light.studio_up");
		///<summary>Test</summary>
		public LightEntity Test => new(_haContext, "light.test");
		///<summary>TV Stand</summary>
		public LightEntity TvStand => new(_haContext, "light.tv_stand");
	}

	public partial class MediaPlayerEntities
	{
		private readonly IHaContext _haContext;
		public MediaPlayerEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Bedroom speaker</summary>
		public MediaPlayerEntity BedroomSpeaker => new(_haContext, "media_player.bedroom_speaker");
		///<summary>Basement speaker</summary>
		public MediaPlayerEntity Googlehome1635 => new(_haContext, "media_player.googlehome1635");
		///<summary>Office speaker</summary>
		public MediaPlayerEntity Googlehome9161 => new(_haContext, "media_player.googlehome9161");
		///<summary>Living Room Assistant</summary>
		public MediaPlayerEntity LivingRoomAssistant => new(_haContext, "media_player.living_room_assistant");
		///<summary>Living Room SHIELD</summary>
		public MediaPlayerEntity LivingRoomShield => new(_haContext, "media_player.living_room_shield");
		///<summary>Living Room speaker</summary>
		public MediaPlayerEntity LivingRoomSpeaker => new(_haContext, "media_player.living_room_speaker");
		///<summary>SHIELD</summary>
		public MediaPlayerEntity Shield => new(_haContext, "media_player.shield");
		///<summary>SHIELD</summary>
		public MediaPlayerEntity Shield2 => new(_haContext, "media_player.shield_2");
		///<summary>VSX-1022</summary>
		public MediaPlayerEntity Vsx1022 => new(_haContext, "media_player.vsx_1022");
	}

	public partial class NumberEntities
	{
		private readonly IHaContext _haContext;
		public NumberEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Philips LCT016 a7248e03 level start_up_current_level</summary>
		public NumberEntity PhilipsLct016A7248e03LevelStartUpCurrentLevel => new(_haContext, "number.philips_lct016_a7248e03_level_start_up_current_level");
	}

	public partial class PersonEntities
	{
		private readonly IHaContext _haContext;
		public PersonEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Jonathan</summary>
		public PersonEntity Jonathan => new(_haContext, "person.jonathan");
		///<summary>Jonathan</summary>
		public PersonEntity Jonathan2 => new(_haContext, "person.jonathan_2");
	}

	public partial class SceneEntities
	{
		private readonly IHaContext _haContext;
		public SceneEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Night Light</summary>
		public SceneEntity NightLight => new(_haContext, "scene.night_light");
		///<summary>Normal Lights</summary>
		public SceneEntity NormalLights => new(_haContext, "scene.normal_lights");
		///<summary>Random_Colors</summary>
		public SceneEntity RandomColors => new(_haContext, "scene.random_colors");
		///<summary>Vacation Lights</summary>
		public SceneEntity VacationLights => new(_haContext, "scene.vacation_lights");
	}

	public partial class ScriptEntities
	{
		private readonly IHaContext _haContext;
		public ScriptEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>k_center</summary>
		public ScriptEntity KCenter => new(_haContext, "script.k_center");
		///<summary>k_down</summary>
		public ScriptEntity KDown => new(_haContext, "script.k_down");
		///<summary>k_left</summary>
		public ScriptEntity KLeft => new(_haContext, "script.k_left");
		///<summary>k_right</summary>
		public ScriptEntity KRight => new(_haContext, "script.k_right");
		///<summary>k_up</summary>
		public ScriptEntity KUp => new(_haContext, "script.k_up");
	}

	public partial class SelectEntities
	{
		private readonly IHaContext _haContext;
		public SelectEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Philips LCT016 a7248e03 on_off StartUpOnOff</summary>
		public SelectEntity PhilipsLct016A7248e03OnOffStartuponoff => new(_haContext, "select.philips_lct016_a7248e03_on_off_startuponoff");
	}

	public partial class SensorEntities
	{
		private readonly IHaContext _haContext;
		public SensorEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Allergy Index: Forecasted Average</summary>
		public SensorEntity AllergyIndexForecastedAverage => new(_haContext, "sensor.allergy_index_forecasted_average");
		///<summary>Allergy Index: Today</summary>
		public SensorEntity AllergyIndexToday => new(_haContext, "sensor.allergy_index_today");
		///<summary>Allergy Index: Tomorrow</summary>
		public SensorEntity AllergyIndexTomorrow => new(_haContext, "sensor.allergy_index_tomorrow");
		///<summary>Asthma Index: Forecasted Average</summary>
		public SensorEntity AsthmaIndexForecastedAverage => new(_haContext, "sensor.asthma_index_forecasted_average");
		///<summary>Asthma Index: Today</summary>
		public SensorEntity AsthmaIndexToday => new(_haContext, "sensor.asthma_index_today");
		///<summary>Asthma Index: Tomorrow</summary>
		public SensorEntity AsthmaIndexTomorrow => new(_haContext, "sensor.asthma_index_tomorrow");
		///<summary>Canon G7000 series</summary>
		public SensorEntity CanonG7000Series => new(_haContext, "sensor.canon_g7000_series");
		///<summary>Cold & Flu: Forecasted Average</summary>
		public SensorEntity ColdFluForecastedAverage => new(_haContext, "sensor.cold_flu_forecasted_average");
		///<summary>Cold & Flu Index: Today</summary>
		public SensorEntity ColdFluIndexToday => new(_haContext, "sensor.cold_flu_index_today");
		///<summary>Load (15m)</summary>
		public SensorEntity Load15m => new(_haContext, "sensor.load_15m");
		///<summary>Pixel 6 Pro Battery Health</summary>
		public SensorEntity Pixel6ProBatteryHealth => new(_haContext, "sensor.pixel_6_pro_battery_health");
		///<summary>Pixel 6 Pro Battery State</summary>
		public SensorEntity Pixel6ProBatteryState => new(_haContext, "sensor.pixel_6_pro_battery_state");
		///<summary>Pixel 6 Pro Charger Type</summary>
		public SensorEntity Pixel6ProChargerType => new(_haContext, "sensor.pixel_6_pro_charger_type");
		///<summary>RBR20 (Gateway) External IP</summary>
		public SensorEntity Rbr20GatewayExternalIp => new(_haContext, "sensor.rbr20_gateway_external_ip");
		///<summary>RBR20 (Gateway) wan status</summary>
		public SensorEntity Rbr20GatewayWanStatus => new(_haContext, "sensor.rbr20_gateway_wan_status");
		///<summary>SM-G973U Battery Health</summary>
		public SensorEntity SmG973uBatteryHealth => new(_haContext, "sensor.sm_g973u_battery_health");
		///<summary>SM-G973U Battery State</summary>
		public SensorEntity SmG973uBatteryState => new(_haContext, "sensor.sm_g973u_battery_state");
		///<summary>SM-G973U Charger Type</summary>
		public SensorEntity SmG973uChargerType => new(_haContext, "sensor.sm_g973u_charger_type");
		///<summary>SM-G973U Do Not Disturb Sensor</summary>
		public SensorEntity SmG973uDoNotDisturbSensor => new(_haContext, "sensor.sm_g973u_do_not_disturb_sensor");
		///<summary>SM-G973U Geocoded Location</summary>
		public SensorEntity SmG973uGeocodedLocation => new(_haContext, "sensor.sm_g973u_geocoded_location");
		///<summary>SM-G973U Last Reboot</summary>
		public SensorEntity SmG973uLastReboot => new(_haContext, "sensor.sm_g973u_last_reboot");
		///<summary>SM-G973U Next Alarm</summary>
		public SensorEntity SmG973uNextAlarm => new(_haContext, "sensor.sm_g973u_next_alarm");
		///<summary>SM-G973U Proximity Sensor</summary>
		public SensorEntity SmG973uProximitySensor => new(_haContext, "sensor.sm_g973u_proximity_sensor");
		///<summary>SM-G973U Ringer Mode</summary>
		public SensorEntity SmG973uRingerMode => new(_haContext, "sensor.sm_g973u_ringer_mode");
		///<summary>SM-G973U WiFi Connection</summary>
		public SensorEntity SmG973uWifiConnection => new(_haContext, "sensor.sm_g973u_wifi_connection");
		///<summary>worxlandroid-state</summary>
		public SensorEntity WorxlandroidState => new(_haContext, "sensor.worxlandroid_state");
		///<summary>Bedroom 1 Temp Battery</summary>
		public NumericSensorEntity BattBedroom1Temp => new(_haContext, "sensor.batt_bedroom_1_temp");
		///<summary>Bedroom 2 Temp Battery</summary>
		public NumericSensorEntity BattBedroom2Temp => new(_haContext, "sensor.batt_bedroom_2_temp");
		///<summary>Bedroom Temp Battery</summary>
		public NumericSensorEntity BattBedroomTemp => new(_haContext, "sensor.batt_bedroom_temp");
		///<summary>Battery Leak Sump</summary>
		public NumericSensorEntity BattLeakSump => new(_haContext, "sensor.batt_leak_sump");
		///<summary>Leak Water Main Battery</summary>
		public NumericSensorEntity BattLeakWaterMain => new(_haContext, "sensor.batt_leak_water_main");
		///<summary>Leak Window East Battery</summary>
		public NumericSensorEntity BattLeakWindowEast => new(_haContext, "sensor.batt_leak_window_east");
		///<summary>Leak WIndow North Battery</summary>
		public NumericSensorEntity BattLeakWindowNorth => new(_haContext, "sensor.batt_leak_window_north");
		///<summary>Living Room Temp Battery</summary>
		public NumericSensorEntity BattLivingRoomTemp => new(_haContext, "sensor.batt_living_room_temp");
		///<summary>Office Temp Battery</summary>
		public NumericSensorEntity BattOfficeTemp => new(_haContext, "sensor.batt_office_temp");
		///<summary>Bedroom 1 Humidity</summary>
		public NumericSensorEntity Bedroom1H => new(_haContext, "sensor.bedroom_1_h");
		///<summary>Bedroom 1 Temp</summary>
		public NumericSensorEntity Bedroom1Temp => new(_haContext, "sensor.bedroom_1_temp");
		///<summary>Bedroom 2 Humidity</summary>
		public NumericSensorEntity Bedroom2H => new(_haContext, "sensor.bedroom_2_h");
		///<summary>Bedroom 2 Pressure</summary>
		public NumericSensorEntity Bedroom2P => new(_haContext, "sensor.bedroom_2_p");
		///<summary>Bedroom 2 Temp</summary>
		public NumericSensorEntity Bedroom2Temp => new(_haContext, "sensor.bedroom_2_temp");
		///<summary>Bedroom Humidity</summary>
		public NumericSensorEntity BedroomH => new(_haContext, "sensor.bedroom_h");
		///<summary>Bedroom Pressure</summary>
		public NumericSensorEntity BedroomP => new(_haContext, "sensor.bedroom_p");
		///<summary>Bedroom Temperature</summary>
		public NumericSensorEntity BedroomTemp => new(_haContext, "sensor.bedroom_temp");
		///<summary>Humidity</summary>
		public NumericSensorEntity BlackskyHumidity => new(_haContext, "sensor.blacksky_humidity");
		///<summary>Temperature</summary>
		public NumericSensorEntity BlackskyTemperature => new(_haContext, "sensor.blacksky_temperature");
		///<summary>Canon G7000 series Black(PGBK)</summary>
		public NumericSensorEntity CanonG7000SeriesBlackPgbk => new(_haContext, "sensor.canon_g7000_series_black_pgbk");
		///<summary>Canon G7000 series Cyan</summary>
		public NumericSensorEntity CanonG7000SeriesCyan => new(_haContext, "sensor.canon_g7000_series_cyan");
		///<summary>Canon G7000 series Magenta</summary>
		public NumericSensorEntity CanonG7000SeriesMagenta => new(_haContext, "sensor.canon_g7000_series_magenta");
		///<summary>Canon G7000 series Yellow</summary>
		public NumericSensorEntity CanonG7000SeriesYellow => new(_haContext, "sensor.canon_g7000_series_yellow");
		///<summary>Circadian Values</summary>
		public NumericSensorEntity CircadianValues => new(_haContext, "sensor.circadian_values");
		///<summary>CPU</summary>
		public NumericSensorEntity Cpu => new(_haContext, "sensor.cpu");
		///<summary>hacs</summary>
		public NumericSensorEntity Hacs => new(_haContext, "sensor.hacs");
		///<summary>Home Transit Time</summary>
		public NumericSensorEntity HomeTransitTime => new(_haContext, "sensor.home_transit_time");
		///<summary>Hue dimmer switch 1 Battery</summary>
		public NumericSensorEntity HueDimmerSwitch1BatteryLevel => new(_haContext, "sensor.hue_dimmer_switch_1_battery_level");
		///<summary>HVAC Filter Pa</summary>
		public NumericSensorEntity HvacFilterPa => new(_haContext, "sensor.hvac_filter_pa");
		///<summary>HVAC Filter WC</summary>
		public NumericSensorEntity HvacFilterWc => new(_haContext, "sensor.hvac_filter_wc");
		///<summary>HVAC Flow</summary>
		public NumericSensorEntity HvacFlow => new(_haContext, "sensor.hvac_flow");
		///<summary>HVAC H Input</summary>
		public NumericSensorEntity HvacHInput => new(_haContext, "sensor.hvac_h_input");
		///<summary>HVAC H Output</summary>
		public NumericSensorEntity HvacHOutput => new(_haContext, "sensor.hvac_h_output");
		///<summary>HVAC T Input</summary>
		public NumericSensorEntity HvacTInput => new(_haContext, "sensor.hvac_t_input");
		///<summary>HVAC T Output</summary>
		public NumericSensorEntity HvacTOutput => new(_haContext, "sensor.hvac_t_output");
		///<summary>HVAC UVC</summary>
		public NumericSensorEntity HvacUvc => new(_haContext, "sensor.hvac_uvc");
		///<summary>Living Room Humidity</summary>
		public NumericSensorEntity LivingRoomHumidity => new(_haContext, "sensor.living_room_humidity");
		///<summary>Living Room Pressure</summary>
		public NumericSensorEntity LivingRoomPressure => new(_haContext, "sensor.living_room_pressure");
		///<summary>Living Room Right</summary>
		public NumericSensorEntity LivingRoomRight => new(_haContext, "sensor.living_room_right");
		///<summary>Living Room Temperature</summary>
		public NumericSensorEntity LivingRoomTemp => new(_haContext, "sensor.living_room_temp");
		///<summary>CPU</summary>
		public NumericSensorEntity Load15mPct => new(_haContext, "sensor.load_15m_pct");
		///<summary>LUMI lumi.sensor_wleak.aq1 603d3306 device_temperature</summary>
		public NumericSensorEntity LumiLumiSensorWleakAq1603d3306DeviceTemperature => new(_haContext, "sensor.lumi_lumi_sensor_wleak_aq1_603d3306_device_temperature");
		///<summary>LUMI lumi.sensor_wleak.aq1 98a13506 device_temperature</summary>
		public NumericSensorEntity LumiLumiSensorWleakAq198a13506DeviceTemperature => new(_haContext, "sensor.lumi_lumi_sensor_wleak_aq1_98a13506_device_temperature");
		///<summary>LUMI lumi.sensor_wleak.aq1 aeb53306 device_temperature</summary>
		public NumericSensorEntity LumiLumiSensorWleakAq1Aeb53306DeviceTemperature => new(_haContext, "sensor.lumi_lumi_sensor_wleak_aq1_aeb53306_device_temperature");
		///<summary>LUMI lumi.sensor_wleak.aq1 cd333306 device_temperature</summary>
		public NumericSensorEntity LumiLumiSensorWleakAq1Cd333306DeviceTemperature => new(_haContext, "sensor.lumi_lumi_sensor_wleak_aq1_cd333306_device_temperature");
		///<summary>Bedroom 1 Pressure</summary>
		public NumericSensorEntity LumiLumiWeatherPressure => new(_haContext, "sensor.lumi_lumi_weather_pressure");
		///<summary>Marion</summary>
		public NumericSensorEntity Marion => new(_haContext, "sensor.marion");
		///<summary>Memory use</summary>
		public NumericSensorEntity MemoryUse => new(_haContext, "sensor.memory_use");
		///<summary>Mold Indicator</summary>
		public NumericSensorEntity MoldIndicator => new(_haContext, "sensor.mold_indicator");
		///<summary>Office Humidity</summary>
		public NumericSensorEntity OfficeHum => new(_haContext, "sensor.office_hum");
		///<summary>Office Temp pressure</summary>
		public NumericSensorEntity OfficePressure => new(_haContext, "sensor.office_pressure");
		///<summary>Office Temp temperature</summary>
		public NumericSensorEntity OfficeTemp => new(_haContext, "sensor.office_temp");
		///<summary>Pi-Hole Ads Blocked Today</summary>
		public NumericSensorEntity PiHoleAdsBlockedToday => new(_haContext, "sensor.pi_hole_ads_blocked_today");
		///<summary>Pi-Hole Ads Percentage Blocked Today</summary>
		public NumericSensorEntity PiHoleAdsPercentageBlockedToday => new(_haContext, "sensor.pi_hole_ads_percentage_blocked_today");
		///<summary>Pi-Hole DNS Queries Cached</summary>
		public NumericSensorEntity PiHoleDnsQueriesCached => new(_haContext, "sensor.pi_hole_dns_queries_cached");
		///<summary>Pi-Hole DNS Queries Forwarded</summary>
		public NumericSensorEntity PiHoleDnsQueriesForwarded => new(_haContext, "sensor.pi_hole_dns_queries_forwarded");
		///<summary>Pi-Hole DNS Queries Today</summary>
		public NumericSensorEntity PiHoleDnsQueriesToday => new(_haContext, "sensor.pi_hole_dns_queries_today");
		///<summary>Pi-Hole DNS Unique Clients</summary>
		public NumericSensorEntity PiHoleDnsUniqueClients => new(_haContext, "sensor.pi_hole_dns_unique_clients");
		///<summary>Pi-Hole DNS Unique Domains</summary>
		public NumericSensorEntity PiHoleDnsUniqueDomains => new(_haContext, "sensor.pi_hole_dns_unique_domains");
		///<summary>Pi-Hole Domains Blocked</summary>
		public NumericSensorEntity PiHoleDomainsBlocked => new(_haContext, "sensor.pi_hole_domains_blocked");
		///<summary>Cached</summary>
		public NumericSensorEntity PiHolePercentCached => new(_haContext, "sensor.pi_hole_percent_cached");
		///<summary>Pi-Hole Seen Clients</summary>
		public NumericSensorEntity PiHoleSeenClients => new(_haContext, "sensor.pi_hole_seen_clients");
		///<summary>Pixel 6 Pro Battery Level</summary>
		public NumericSensorEntity Pixel6ProBatteryLevel => new(_haContext, "sensor.pixel_6_pro_battery_level");
		///<summary>Pixel 6 Pro Battery Temperature</summary>
		public NumericSensorEntity Pixel6ProBatteryTemperature => new(_haContext, "sensor.pixel_6_pro_battery_temperature");
		///<summary>RBR20 (Gateway) B received</summary>
		public NumericSensorEntity Rbr20GatewayBReceived => new(_haContext, "sensor.rbr20_gateway_b_received");
		///<summary>RBR20 (Gateway) B sent</summary>
		public NumericSensorEntity Rbr20GatewayBSent => new(_haContext, "sensor.rbr20_gateway_b_sent");
		///<summary>RBR20 (Gateway) KiB/s received</summary>
		public NumericSensorEntity Rbr20GatewayKibSReceived => new(_haContext, "sensor.rbr20_gateway_kib_s_received");
		///<summary>RBR20 (Gateway) KiB/s sent</summary>
		public NumericSensorEntity Rbr20GatewayKibSSent => new(_haContext, "sensor.rbr20_gateway_kib_s_sent");
		///<summary>RBR20 (Gateway) packets received</summary>
		public NumericSensorEntity Rbr20GatewayPacketsReceived => new(_haContext, "sensor.rbr20_gateway_packets_received");
		///<summary>RBR20 (Gateway) packets/s received</summary>
		public NumericSensorEntity Rbr20GatewayPacketsSReceived => new(_haContext, "sensor.rbr20_gateway_packets_s_received");
		///<summary>RBR20 (Gateway) packets/s sent</summary>
		public NumericSensorEntity Rbr20GatewayPacketsSSent => new(_haContext, "sensor.rbr20_gateway_packets_s_sent");
		///<summary>RBR20 (Gateway) packets sent</summary>
		public NumericSensorEntity Rbr20GatewayPacketsSent => new(_haContext, "sensor.rbr20_gateway_packets_sent");
		///<summary>Server UPS Battery Runtime</summary>
		public NumericSensorEntity ServerUpsBatteryRuntime => new(_haContext, "sensor.server_ups_battery_runtime");
		///<summary>Server UPS Input Voltage</summary>
		public NumericSensorEntity ServerUpsInputVoltage => new(_haContext, "sensor.server_ups_input_voltage");
		///<summary>Server UPS Load</summary>
		public NumericSensorEntity ServerUpsLoad => new(_haContext, "sensor.server_ups_load");
		///<summary>Server UPS Nominal Real Power</summary>
		public NumericSensorEntity ServerUpsNominalRealPower => new(_haContext, "sensor.server_ups_nominal_real_power");
		///<summary>Power Usage</summary>
		public NumericSensorEntity Serverpower => new(_haContext, "sensor.serverpower");
		///<summary>SM-G973U Battery Level</summary>
		public NumericSensorEntity SmG973uBatteryLevel => new(_haContext, "sensor.sm_g973u_battery_level");
		///<summary>SM-G973U Battery Temperature</summary>
		public NumericSensorEntity SmG973uBatteryTemperature => new(_haContext, "sensor.sm_g973u_battery_temperature");
		///<summary>SM-G973U Bluetooth Connection</summary>
		public NumericSensorEntity SmG973uBluetoothConnection => new(_haContext, "sensor.sm_g973u_bluetooth_connection");
		///<summary>SM-G973U Internal Storage</summary>
		public NumericSensorEntity SmG973uInternalStorage => new(_haContext, "sensor.sm_g973u_internal_storage");
		///<summary>SM-G973U Light Sensor</summary>
		public NumericSensorEntity SmG973uLightSensor => new(_haContext, "sensor.sm_g973u_light_sensor");
		///<summary>SM-G973U Pressure Sensor</summary>
		public NumericSensorEntity SmG973uPressureSensor => new(_haContext, "sensor.sm_g973u_pressure_sensor");
		///<summary>Breakfast Center</summary>
		public NumericSensorEntity TradfriBlind => new(_haContext, "sensor.tradfri_blind");
		///<summary>Breakfast Left</summary>
		public NumericSensorEntity TradfriBlind2 => new(_haContext, "sensor.tradfri_blind_2");
		///<summary>Breakfast Right</summary>
		public NumericSensorEntity TradfriBlind3 => new(_haContext, "sensor.tradfri_blind_3");
		///<summary>Living Room Left</summary>
		public NumericSensorEntity TradfriBlind4 => new(_haContext, "sensor.tradfri_blind_4");
		///<summary>Living Room Center</summary>
		public NumericSensorEntity TradfriBlind6 => new(_haContext, "sensor.tradfri_blind_6");
		///<summary>TRADFRI open/close remote</summary>
		public NumericSensorEntity TradfriOpenCloseRemote => new(_haContext, "sensor.tradfri_open_close_remote");
		///<summary>TRADFRI remote control</summary>
		public NumericSensorEntity TradfriRemoteControl => new(_haContext, "sensor.tradfri_remote_control");
		///<summary>Carbon Monoxide</summary>
		public NumericSensorEntity WaqiCo => new(_haContext, "sensor.waqi_co");
		///<summary>WAQI Indpls - I-70 E, Indiana, USA</summary>
		public NumericSensorEntity WaqiIndplsI70EIndianaUsa => new(_haContext, "sensor.waqi_indpls_i_70_e_indiana_usa");
		///<summary>Ozone</summary>
		public NumericSensorEntity WaqiOzone => new(_haContext, "sensor.waqi_ozone");
		///<summary>PM 2.5</summary>
		public NumericSensorEntity WaqiPm25 => new(_haContext, "sensor.waqi_pm25");
		///<summary>Work Transit Time</summary>
		public NumericSensorEntity WorkTransitTime => new(_haContext, "sensor.work_transit_time");
		///<summary>worxlandroid-battery</summary>
		public NumericSensorEntity WorxlandroidBattery => new(_haContext, "sensor.worxlandroid_battery");
	}

	public partial class SunEntities
	{
		private readonly IHaContext _haContext;
		public SunEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Sun</summary>
		public SunEntity Sun => new(_haContext, "sun.sun");
	}

	public partial class SwitchEntities
	{
		private readonly IHaContext _haContext;
		public SwitchEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Bedroom Heat</summary>
		public SwitchEntity BedroomHeat => new(_haContext, "switch.bedroom_heat");
		///<summary>Calibrate</summary>
		public SwitchEntity Calibrate => new(_haContext, "switch.calibrate");
		///<summary>Dining Room LED</summary>
		public SwitchEntity DiningRoomLed => new(_haContext, "switch.dining_room_led");
		///<summary>Ground Lights</summary>
		public SwitchEntity GroundLights => new(_haContext, "switch.ground_lights");
		///<summary>Modem</summary>
		public SwitchEntity Modem => new(_haContext, "switch.modem");
		///<summary>Modem LED</summary>
		public SwitchEntity ModemLed => new(_haContext, "switch.modem_led");
		///<summary>Space Heater</summary>
		public SwitchEntity SpaceHeater => new(_haContext, "switch.space_heater");
		///<summary>String Lights</summary>
		public SwitchEntity StringLights => new(_haContext, "switch.string_lights");
		///<summary>TP-LINK_Smart Plug_3ADF LED</summary>
		public SwitchEntity TpLinkSmartPlug3adfLed => new(_haContext, "switch.tp_link_smart_plug_3adf_led");
	}

	public partial class UpdateEntities
	{
		private readonly IHaContext _haContext;
		public UpdateEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Home Assistant Core: Update</summary>
		public UpdateEntity HomeAssistantCoreUpdate => new(_haContext, "update.home_assistant_core_update");
		///<summary>Home Assistant Supervisor: Update</summary>
		public UpdateEntity HomeAssistantSupervisorUpdate => new(_haContext, "update.home_assistant_supervisor_update");
		///<summary>NetDaemon V3 - beta: Update</summary>
		public UpdateEntity NetdaemonV3BetaUpdate => new(_haContext, "update.netdaemon_v3_beta_update");
		///<summary>Pi-Hole Core Update Available</summary>
		public UpdateEntity PiHoleCoreUpdateAvailable => new(_haContext, "update.pi_hole_core_update_available");
		///<summary>Pi-Hole FTL Update Available</summary>
		public UpdateEntity PiHoleFtlUpdateAvailable => new(_haContext, "update.pi_hole_ftl_update_available");
		///<summary>Pi-Hole Web Update Available</summary>
		public UpdateEntity PiHoleWebUpdateAvailable => new(_haContext, "update.pi_hole_web_update_available");
		///<summary>Z-Wave JS: Update</summary>
		public UpdateEntity ZWaveJsUpdate => new(_haContext, "update.z_wave_js_update");
	}

	public partial class WeatherEntities
	{
		private readonly IHaContext _haContext;
		public WeatherEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Dark Sky</summary>
		public WeatherEntity DarkSky => new(_haContext, "weather.dark_sky");
		///<summary>Home</summary>
		public WeatherEntity Home => new(_haContext, "weather.home");
	}

	public partial class ZoneEntities
	{
		private readonly IHaContext _haContext;
		public ZoneEntities(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Home</summary>
		public ZoneEntity Home => new(_haContext, "zone.home");
	}

	public partial record AutomationEntity : Entity<AutomationEntity, EntityState<AutomationAttributes>, AutomationAttributes>
	{
		public AutomationEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public AutomationEntity(Entity entity) : base(entity)
		{
		}
	}

	public record AutomationAttributes
	{
		[JsonPropertyName("current")]
		public double? Current { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("id")]
		public string? Id { get; init; }

		[JsonPropertyName("last_triggered")]
		public string? LastTriggered { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record BinarySensorEntity : Entity<BinarySensorEntity, EntityState<BinarySensorAttributes>, BinarySensorAttributes>
	{
		public BinarySensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public BinarySensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record BinarySensorAttributes
	{
		[JsonPropertyName("battery_level")]
		public double? BatteryLevel { get; init; }

		[JsonPropertyName("child_id")]
		public double? ChildId { get; init; }

		[JsonPropertyName("description")]
		public string? Description { get; init; }

		[JsonPropertyName("device")]
		public string? Device { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("heartbeat")]
		public double? Heartbeat { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("node_id")]
		public double? NodeId { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("V_TRIPPED")]
		public string? VTRIPPED { get; init; }
	}

	public partial record ButtonEntity : Entity<ButtonEntity, EntityState<ButtonAttributes>, ButtonAttributes>
	{
		public ButtonEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ButtonEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ButtonAttributes
	{
		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }
	}

	public partial record CameraEntity : Entity<CameraEntity, EntityState<CameraAttributes>, CameraAttributes>
	{
		public CameraEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CameraEntity(Entity entity) : base(entity)
		{
		}
	}

	public record CameraAttributes
	{
		[JsonPropertyName("access_token")]
		public string? AccessToken { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record CoverEntity : Entity<CoverEntity, EntityState<CoverAttributes>, CoverAttributes>
	{
		public CoverEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public CoverEntity(Entity entity) : base(entity)
		{
		}
	}

	public record CoverAttributes
	{
		[JsonPropertyName("current_position")]
		public double? CurrentPosition { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("entity_id")]
		public IReadOnlyList<string>? EntityId { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("model")]
		public string? Model { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record DeviceTrackerEntity : Entity<DeviceTrackerEntity, EntityState<DeviceTrackerAttributes>, DeviceTrackerAttributes>
	{
		public DeviceTrackerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public DeviceTrackerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record DeviceTrackerAttributes
	{
		[JsonPropertyName("altitude")]
		public double? Altitude { get; init; }

		[JsonPropertyName("course")]
		public double? Course { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("gps_accuracy")]
		public double? GpsAccuracy { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("source_type")]
		public string? SourceType { get; init; }

		[JsonPropertyName("speed")]
		public double? Speed { get; init; }

		[JsonPropertyName("vertical_accuracy")]
		public double? VerticalAccuracy { get; init; }
	}

	public partial record FanEntity : Entity<FanEntity, EntityState<FanAttributes>, FanAttributes>
	{
		public FanEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public FanEntity(Entity entity) : base(entity)
		{
		}
	}

	public record FanAttributes
	{
		[JsonPropertyName("device_id")]
		public string? DeviceId { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("percentage")]
		public double? Percentage { get; init; }

		[JsonPropertyName("percentage_step")]
		public double? PercentageStep { get; init; }

		[JsonPropertyName("preset_mode")]
		public object? PresetMode { get; init; }

		[JsonPropertyName("preset_modes")]
		public object? PresetModes { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("zone_id")]
		public string? ZoneId { get; init; }
	}

	public partial record InputBooleanEntity : Entity<InputBooleanEntity, EntityState<InputBooleanAttributes>, InputBooleanAttributes>
	{
		public InputBooleanEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputBooleanEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputBooleanAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }
	}

	public partial record InputDatetimeEntity : Entity<InputDatetimeEntity, EntityState<InputDatetimeAttributes>, InputDatetimeAttributes>
	{
		public InputDatetimeEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputDatetimeEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputDatetimeAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("has_date")]
		public bool? HasDate { get; init; }

		[JsonPropertyName("has_time")]
		public bool? HasTime { get; init; }

		[JsonPropertyName("hour")]
		public double? Hour { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("minute")]
		public double? Minute { get; init; }

		[JsonPropertyName("second")]
		public double? Second { get; init; }

		[JsonPropertyName("timestamp")]
		public double? Timestamp { get; init; }
	}

	public partial record InputNumberEntity : NumericEntity<InputNumberEntity, NumericEntityState<InputNumberAttributes>, InputNumberAttributes>
	{
		public InputNumberEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public InputNumberEntity(Entity entity) : base(entity)
		{
		}
	}

	public record InputNumberAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("initial")]
		public object? Initial { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("min")]
		public double? Min { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }

		[JsonPropertyName("step")]
		public double? Step { get; init; }

		[JsonPropertyName("unit_of_measurement")]
		public string? UnitOfMeasurement { get; init; }
	}

	public partial record LightEntity : Entity<LightEntity, EntityState<LightAttributes>, LightAttributes>
	{
		public LightEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public LightEntity(Entity entity) : base(entity)
		{
		}
	}

	public record LightAttributes
	{
		[JsonPropertyName("brightness")]
		public double? Brightness { get; init; }

		[JsonPropertyName("color_mode")]
		public string? ColorMode { get; init; }

		[JsonPropertyName("device_id")]
		public string? DeviceId { get; init; }

		[JsonPropertyName("dynamics")]
		public string? Dynamics { get; init; }

		[JsonPropertyName("effect")]
		public string? Effect { get; init; }

		[JsonPropertyName("effect_list")]
		public IReadOnlyList<string>? EffectList { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("hs_color")]
		public IReadOnlyList<double>? HsColor { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("max_mireds")]
		public double? MaxMireds { get; init; }

		[JsonPropertyName("min_mireds")]
		public double? MinMireds { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }

		[JsonPropertyName("rgb_color")]
		public IReadOnlyList<double>? RgbColor { get; init; }

		[JsonPropertyName("supported_color_modes")]
		public IReadOnlyList<string>? SupportedColorModes { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("xy_color")]
		public IReadOnlyList<double>? XyColor { get; init; }

		[JsonPropertyName("zone_id")]
		public string? ZoneId { get; init; }
	}

	public partial record MediaPlayerEntity : Entity<MediaPlayerEntity, EntityState<MediaPlayerAttributes>, MediaPlayerAttributes>
	{
		public MediaPlayerEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public MediaPlayerEntity(Entity entity) : base(entity)
		{
		}
	}

	public record MediaPlayerAttributes
	{
		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record NumberEntity : NumericEntity<NumberEntity, NumericEntityState<NumberAttributes>, NumberAttributes>
	{
		public NumberEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public NumberEntity(Entity entity) : base(entity)
		{
		}
	}

	public record NumberAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("max")]
		public double? Max { get; init; }

		[JsonPropertyName("min")]
		public double? Min { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }

		[JsonPropertyName("step")]
		public double? Step { get; init; }
	}

	public partial record PersonEntity : Entity<PersonEntity, EntityState<PersonAttributes>, PersonAttributes>
	{
		public PersonEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public PersonEntity(Entity entity) : base(entity)
		{
		}
	}

	public record PersonAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("id")]
		public string? Id { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("user_id")]
		public string? UserId { get; init; }
	}

	public partial record SceneEntity : Entity<SceneEntity, EntityState<SceneAttributes>, SceneAttributes>
	{
		public SceneEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SceneEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SceneAttributes
	{
		[JsonPropertyName("entity_id")]
		public IReadOnlyList<object>? EntityId { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("id")]
		public string? Id { get; init; }
	}

	public partial record ScriptEntity : Entity<ScriptEntity, EntityState<ScriptAttributes>, ScriptAttributes>
	{
		public ScriptEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ScriptEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ScriptAttributes
	{
		[JsonPropertyName("current")]
		public double? Current { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("last_triggered")]
		public string? LastTriggered { get; init; }

		[JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public partial record SelectEntity : Entity<SelectEntity, EntityState<SelectAttributes>, SelectAttributes>
	{
		public SelectEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SelectEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SelectAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("options")]
		public IReadOnlyList<string>? Options { get; init; }
	}

	public partial record SensorEntity : Entity<SensorEntity, EntityState<SensorAttributes>, SensorAttributes>
	{
		public SensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SensorAttributes
	{
		[JsonPropertyName("Administrative Area")]
		public string? AdministrativeArea { get; init; }

		[JsonPropertyName("allergen_amount_1")]
		public double? AllergenAmount1 { get; init; }

		[JsonPropertyName("allergen_amount_2")]
		public double? AllergenAmount2 { get; init; }

		[JsonPropertyName("allergen_amount_3")]
		public double? AllergenAmount3 { get; init; }

		[JsonPropertyName("allergen_genus_1")]
		public string? AllergenGenus1 { get; init; }

		[JsonPropertyName("allergen_genus_2")]
		public string? AllergenGenus2 { get; init; }

		[JsonPropertyName("allergen_name_1")]
		public string? AllergenName1 { get; init; }

		[JsonPropertyName("allergen_name_2")]
		public string? AllergenName2 { get; init; }

		[JsonPropertyName("allergen_name_3")]
		public string? AllergenName3 { get; init; }

		[JsonPropertyName("allergen_type_1")]
		public string? AllergenType1 { get; init; }

		[JsonPropertyName("allergen_type_2")]
		public string? AllergenType2 { get; init; }

		[JsonPropertyName("city")]
		public string? City { get; init; }

		[JsonPropertyName("command_set")]
		public string? CommandSet { get; init; }

		[JsonPropertyName("cough_index")]
		public double? CoughIndex { get; init; }

		[JsonPropertyName("Country")]
		public string? Country { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("fever_index")]
		public double? FeverIndex { get; init; }

		[JsonPropertyName("flu_index")]
		public double? FluIndex { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("info")]
		public string? Info { get; init; }

		[JsonPropertyName("is_hidden")]
		public bool? IsHidden { get; init; }

		[JsonPropertyName("ISO Country Code")]
		public string? ISOCountryCode { get; init; }

		[JsonPropertyName("Latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("Locality")]
		public string? Locality { get; init; }

		[JsonPropertyName("Local Time")]
		public string? LocalTime { get; init; }

		[JsonPropertyName("location")]
		public string? Location { get; init; }

		[JsonPropertyName("Longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("outlook")]
		public string? Outlook { get; init; }

		[JsonPropertyName("Postal Code")]
		public string? PostalCode { get; init; }

		[JsonPropertyName("rating")]
		public string? Rating { get; init; }

		[JsonPropertyName("season")]
		public string? Season { get; init; }

		[JsonPropertyName("serial")]
		public object? Serial { get; init; }

		[JsonPropertyName("state")]
		public string? State { get; init; }

		[JsonPropertyName("state_class")]
		public string? StateClass { get; init; }

		[JsonPropertyName("state_message")]
		public object? StateMessage { get; init; }

		[JsonPropertyName("state_reason")]
		public object? StateReason { get; init; }

		[JsonPropertyName("strep_index")]
		public double? StrepIndex { get; init; }

		[JsonPropertyName("Sub Administrative Area")]
		public string? SubAdministrativeArea { get; init; }

		[JsonPropertyName("Sub Locality")]
		public string? SubLocality { get; init; }

		[JsonPropertyName("Sub Thoroughfare")]
		public string? SubThoroughfare { get; init; }

		[JsonPropertyName("Thoroughfare")]
		public string? Thoroughfare { get; init; }

		[JsonPropertyName("Time in Milliseconds")]
		public double? TimeinMilliseconds { get; init; }

		[JsonPropertyName("trend")]
		public string? Trend { get; init; }

		[JsonPropertyName("uri_supported")]
		public IReadOnlyList<string>? UriSupported { get; init; }

		[JsonPropertyName("zip_code")]
		public string? ZipCode { get; init; }
	}

	public partial record NumericSensorEntity : NumericEntity<NumericSensorEntity, NumericEntityState<NumericSensorAttributes>, NumericSensorAttributes>
	{
		public NumericSensorEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public NumericSensorEntity(Entity entity) : base(entity)
		{
		}
	}

	public record NumericSensorAttributes
	{
		[JsonPropertyName("alerts")]
		public IReadOnlyList<object>? Alerts { get; init; }

		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("battery_state")]
		public string? BatteryState { get; init; }

		[JsonPropertyName("battery_voltage")]
		public double? BatteryVoltage { get; init; }

		[JsonPropertyName("co")]
		public double? Co { get; init; }

		[JsonPropertyName("colortemp")]
		public double? Colortemp { get; init; }

		[JsonPropertyName("connected_not_paired_devices")]
		public string? ConnectedNotPairedDevices { get; init; }

		[JsonPropertyName("connected_paired_devices")]
		public string? ConnectedPairedDevices { get; init; }

		[JsonPropertyName("destination")]
		public string? Destination { get; init; }

		[JsonPropertyName("device_class")]
		public string? DeviceClass { get; init; }

		[JsonPropertyName("dewpoint")]
		public double? Dewpoint { get; init; }

		[JsonPropertyName("distance")]
		public double? Distance { get; init; }

		[JsonPropertyName("dominentpol")]
		public string? Dominentpol { get; init; }

		[JsonPropertyName("duration")]
		public double? Duration { get; init; }

		[JsonPropertyName("estimated_critical_temp")]
		public double? EstimatedCriticalTemp { get; init; }

		[JsonPropertyName("Free internal storage")]
		public string? Freeinternalstorage { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("humidity")]
		public double? Humidity { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("integration")]
		public string? Integration { get; init; }

		[JsonPropertyName("marker_high_level")]
		public double? MarkerHighLevel { get; init; }

		[JsonPropertyName("marker_low_level")]
		public double? MarkerLowLevel { get; init; }

		[JsonPropertyName("marker_type")]
		public string? MarkerType { get; init; }

		[JsonPropertyName("nitrogen_dioxide")]
		public double? NitrogenDioxide { get; init; }

		[JsonPropertyName("origin")]
		public string? Origin { get; init; }

		[JsonPropertyName("ozone")]
		public double? Ozone { get; init; }

		[JsonPropertyName("paired_devices")]
		public string? PairedDevices { get; init; }

		[JsonPropertyName("pm_2_5")]
		public double? Pm25 { get; init; }

		[JsonPropertyName("pressure")]
		public double? Pressure { get; init; }

		[JsonPropertyName("repositories")]
		public IReadOnlyList<object>? Repositories { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("rgb_color")]
		public IReadOnlyList<double>? RgbColor { get; init; }

		[JsonPropertyName("route")]
		public string? Route { get; init; }

		[JsonPropertyName("state")]
		public string? State { get; init; }

		[JsonPropertyName("state_class")]
		public string? StateClass { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		[JsonPropertyName("time")]
		public string? Time { get; init; }

		[JsonPropertyName("Total internal storage")]
		public string? Totalinternalstorage { get; init; }

		[JsonPropertyName("unit_of_measurement")]
		public string? UnitOfMeasurement { get; init; }

		[JsonPropertyName("w")]
		public double? W { get; init; }

		[JsonPropertyName("wg")]
		public double? Wg { get; init; }

		[JsonPropertyName("xy_color")]
		public IReadOnlyList<double>? XyColor { get; init; }

		[JsonPropertyName("zone")]
		public string? Zone { get; init; }
	}

	public partial record SunEntity : Entity<SunEntity, EntityState<SunAttributes>, SunAttributes>
	{
		public SunEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SunEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SunAttributes
	{
		[JsonPropertyName("azimuth")]
		public double? Azimuth { get; init; }

		[JsonPropertyName("elevation")]
		public double? Elevation { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("next_dawn")]
		public string? NextDawn { get; init; }

		[JsonPropertyName("next_dusk")]
		public string? NextDusk { get; init; }

		[JsonPropertyName("next_midnight")]
		public string? NextMidnight { get; init; }

		[JsonPropertyName("next_noon")]
		public string? NextNoon { get; init; }

		[JsonPropertyName("next_rising")]
		public string? NextRising { get; init; }

		[JsonPropertyName("next_setting")]
		public string? NextSetting { get; init; }

		[JsonPropertyName("rising")]
		public bool? Rising { get; init; }
	}

	public partial record SwitchEntity : Entity<SwitchEntity, EntityState<SwitchAttributes>, SwitchAttributes>
	{
		public SwitchEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public SwitchEntity(Entity entity) : base(entity)
		{
		}
	}

	public record SwitchAttributes
	{
		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }
	}

	public partial record UpdateEntity : Entity<UpdateEntity, EntityState<UpdateAttributes>, UpdateAttributes>
	{
		public UpdateEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public UpdateEntity(Entity entity) : base(entity)
		{
		}
	}

	public record UpdateAttributes
	{
		[JsonPropertyName("auto_update")]
		public bool? AutoUpdate { get; init; }

		[JsonPropertyName("entity_picture")]
		public string? EntityPicture { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("in_progress")]
		public bool? InProgress { get; init; }

		[JsonPropertyName("installed_version")]
		public string? InstalledVersion { get; init; }

		[JsonPropertyName("latest_version")]
		public string? LatestVersion { get; init; }

		[JsonPropertyName("release_summary")]
		public string? ReleaseSummary { get; init; }

		[JsonPropertyName("release_url")]
		public string? ReleaseUrl { get; init; }

		[JsonPropertyName("restored")]
		public bool? Restored { get; init; }

		[JsonPropertyName("skipped_version")]
		public object? SkippedVersion { get; init; }

		[JsonPropertyName("supported_features")]
		public double? SupportedFeatures { get; init; }

		[JsonPropertyName("title")]
		public string? Title { get; init; }
	}

	public partial record WeatherEntity : Entity<WeatherEntity, EntityState<WeatherAttributes>, WeatherAttributes>
	{
		public WeatherEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public WeatherEntity(Entity entity) : base(entity)
		{
		}
	}

	public record WeatherAttributes
	{
		[JsonPropertyName("attribution")]
		public string? Attribution { get; init; }

		[JsonPropertyName("forecast")]
		public IReadOnlyList<object>? Forecast { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("humidity")]
		public double? Humidity { get; init; }

		[JsonPropertyName("ozone")]
		public double? Ozone { get; init; }

		[JsonPropertyName("precipitation_unit")]
		public string? PrecipitationUnit { get; init; }

		[JsonPropertyName("pressure")]
		public double? Pressure { get; init; }

		[JsonPropertyName("pressure_unit")]
		public string? PressureUnit { get; init; }

		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		[JsonPropertyName("temperature_unit")]
		public string? TemperatureUnit { get; init; }

		[JsonPropertyName("visibility")]
		public double? Visibility { get; init; }

		[JsonPropertyName("visibility_unit")]
		public string? VisibilityUnit { get; init; }

		[JsonPropertyName("wind_bearing")]
		public double? WindBearing { get; init; }

		[JsonPropertyName("wind_speed")]
		public double? WindSpeed { get; init; }

		[JsonPropertyName("wind_speed_unit")]
		public string? WindSpeedUnit { get; init; }
	}

	public partial record ZoneEntity : Entity<ZoneEntity, EntityState<ZoneAttributes>, ZoneAttributes>
	{
		public ZoneEntity(IHaContext haContext, string entityId) : base(haContext, entityId)
		{
		}

		public ZoneEntity(Entity entity) : base(entity)
		{
		}
	}

	public record ZoneAttributes
	{
		[JsonPropertyName("editable")]
		public bool? Editable { get; init; }

		[JsonPropertyName("friendly_name")]
		public string? FriendlyName { get; init; }

		[JsonPropertyName("icon")]
		public string? Icon { get; init; }

		[JsonPropertyName("latitude")]
		public double? Latitude { get; init; }

		[JsonPropertyName("longitude")]
		public double? Longitude { get; init; }

		[JsonPropertyName("passive")]
		public bool? Passive { get; init; }

		[JsonPropertyName("persons")]
		public IReadOnlyList<object>? Persons { get; init; }

		[JsonPropertyName("radius")]
		public double? Radius { get; init; }
	}

	public interface IServices
	{
		AlarmControlPanelServices AlarmControlPanel { get; }

		AutomationServices Automation { get; }

		ButtonServices Button { get; }

		CameraServices Camera { get; }

		CastServices Cast { get; }

		CircadianLightingServices CircadianLighting { get; }

		ClimateServices Climate { get; }

		CloudServices Cloud { get; }

		CommandLineServices CommandLine { get; }

		CounterServices Counter { get; }

		CoverServices Cover { get; }

		DeviceTrackerServices DeviceTracker { get; }

		FanServices Fan { get; }

		FrontendServices Frontend { get; }

		GroupServices Group { get; }

		HassioServices Hassio { get; }

		HomeassistantServices Homeassistant { get; }

		HueServices Hue { get; }

		HumidifierServices Humidifier { get; }

		InputBooleanServices InputBoolean { get; }

		InputButtonServices InputButton { get; }

		InputDatetimeServices InputDatetime { get; }

		InputNumberServices InputNumber { get; }

		InputSelectServices InputSelect { get; }

		InputTextServices InputText { get; }

		LightServices Light { get; }

		LockServices Lock { get; }

		LogbookServices Logbook { get; }

		MediaPlayerServices MediaPlayer { get; }

		MqttServices Mqtt { get; }

		MysensorsServices Mysensors { get; }

		NotifyServices Notify { get; }

		NumberServices Number { get; }

		PersistentNotificationServices PersistentNotification { get; }

		PersonServices Person { get; }

		RecorderServices Recorder { get; }

		SceneServices Scene { get; }

		ScriptServices Script { get; }

		SelectServices Select { get; }

		ShoppingListServices ShoppingList { get; }

		SirenServices Siren { get; }

		SwitchServices Switch { get; }

		SystemLogServices SystemLog { get; }

		TemplateServices Template { get; }

		TimerServices Timer { get; }

		TtsServices Tts { get; }

		UpdateServices Update { get; }

		VacuumServices Vacuum { get; }

		ZhaServices Zha { get; }

		ZoneServices Zone { get; }

		ZwaveJsServices ZwaveJs { get; }
	}

	public class Services : IServices
	{
		private readonly IHaContext _haContext;
		public Services(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public AlarmControlPanelServices AlarmControlPanel => new(_haContext);
		public AutomationServices Automation => new(_haContext);
		public ButtonServices Button => new(_haContext);
		public CameraServices Camera => new(_haContext);
		public CastServices Cast => new(_haContext);
		public CircadianLightingServices CircadianLighting => new(_haContext);
		public ClimateServices Climate => new(_haContext);
		public CloudServices Cloud => new(_haContext);
		public CommandLineServices CommandLine => new(_haContext);
		public CounterServices Counter => new(_haContext);
		public CoverServices Cover => new(_haContext);
		public DeviceTrackerServices DeviceTracker => new(_haContext);
		public FanServices Fan => new(_haContext);
		public FrontendServices Frontend => new(_haContext);
		public GroupServices Group => new(_haContext);
		public HassioServices Hassio => new(_haContext);
		public HomeassistantServices Homeassistant => new(_haContext);
		public HueServices Hue => new(_haContext);
		public HumidifierServices Humidifier => new(_haContext);
		public InputBooleanServices InputBoolean => new(_haContext);
		public InputButtonServices InputButton => new(_haContext);
		public InputDatetimeServices InputDatetime => new(_haContext);
		public InputNumberServices InputNumber => new(_haContext);
		public InputSelectServices InputSelect => new(_haContext);
		public InputTextServices InputText => new(_haContext);
		public LightServices Light => new(_haContext);
		public LockServices Lock => new(_haContext);
		public LogbookServices Logbook => new(_haContext);
		public MediaPlayerServices MediaPlayer => new(_haContext);
		public MqttServices Mqtt => new(_haContext);
		public MysensorsServices Mysensors => new(_haContext);
		public NotifyServices Notify => new(_haContext);
		public NumberServices Number => new(_haContext);
		public PersistentNotificationServices PersistentNotification => new(_haContext);
		public PersonServices Person => new(_haContext);
		public RecorderServices Recorder => new(_haContext);
		public SceneServices Scene => new(_haContext);
		public ScriptServices Script => new(_haContext);
		public SelectServices Select => new(_haContext);
		public ShoppingListServices ShoppingList => new(_haContext);
		public SirenServices Siren => new(_haContext);
		public SwitchServices Switch => new(_haContext);
		public SystemLogServices SystemLog => new(_haContext);
		public TemplateServices Template => new(_haContext);
		public TimerServices Timer => new(_haContext);
		public TtsServices Tts => new(_haContext);
		public UpdateServices Update => new(_haContext);
		public VacuumServices Vacuum => new(_haContext);
		public ZhaServices Zha => new(_haContext);
		public ZoneServices Zone => new(_haContext);
		public ZwaveJsServices ZwaveJs => new(_haContext);
	}

	public class AlarmControlPanelServices
	{
		private readonly IHaContext _haContext;
		public AlarmControlPanelServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmAway(ServiceTarget target, AlarmControlPanelAlarmArmAwayParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_away", target, data);
		}

		///<summary>Send the alarm the command for arm away.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm away the alarm control panel with. eg: 1234</param>
		public void AlarmArmAway(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_away", target, new AlarmControlPanelAlarmArmAwayParameters{Code = @code});
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmCustomBypass(ServiceTarget target, AlarmControlPanelAlarmArmCustomBypassParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, data);
		}

		///<summary>Send arm custom bypass command.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm custom bypass the alarm control panel with. eg: 1234</param>
		public void AlarmArmCustomBypass(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_custom_bypass", target, new AlarmControlPanelAlarmArmCustomBypassParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmHome(ServiceTarget target, AlarmControlPanelAlarmArmHomeParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_home", target, data);
		}

		///<summary>Send the alarm the command for arm home.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm home the alarm control panel with. eg: 1234</param>
		public void AlarmArmHome(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_home", target, new AlarmControlPanelAlarmArmHomeParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmNight(ServiceTarget target, AlarmControlPanelAlarmArmNightParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_night", target, data);
		}

		///<summary>Send the alarm the command for arm night.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm night the alarm control panel with. eg: 1234</param>
		public void AlarmArmNight(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_night", target, new AlarmControlPanelAlarmArmNightParameters{Code = @code});
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmArmVacation(ServiceTarget target, AlarmControlPanelAlarmArmVacationParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_vacation", target, data);
		}

		///<summary>Send the alarm the command for arm vacation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to arm vacation the alarm control panel with. eg: 1234</param>
		public void AlarmArmVacation(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_arm_vacation", target, new AlarmControlPanelAlarmArmVacationParameters{Code = @code});
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmDisarm(ServiceTarget target, AlarmControlPanelAlarmDisarmParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_disarm", target, data);
		}

		///<summary>Send the alarm the command for disarm.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to disarm the alarm control panel with. eg: 1234</param>
		public void AlarmDisarm(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_disarm", target, new AlarmControlPanelAlarmDisarmParameters{Code = @code});
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The target for this service call</param>
		public void AlarmTrigger(ServiceTarget target, AlarmControlPanelAlarmTriggerParameters data)
		{
			_haContext.CallService("alarm_control_panel", "alarm_trigger", target, data);
		}

		///<summary>Send the alarm the command for trigger.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to trigger the alarm control panel with. eg: 1234</param>
		public void AlarmTrigger(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("alarm_control_panel", "alarm_trigger", target, new AlarmControlPanelAlarmTriggerParameters{Code = @code});
		}
	}

	public record AlarmControlPanelAlarmArmAwayParameters
	{
		///<summary>An optional code to arm away the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmCustomBypassParameters
	{
		///<summary>An optional code to arm custom bypass the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmHomeParameters
	{
		///<summary>An optional code to arm home the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmNightParameters
	{
		///<summary>An optional code to arm night the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmArmVacationParameters
	{
		///<summary>An optional code to arm vacation the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmDisarmParameters
	{
		///<summary>An optional code to disarm the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record AlarmControlPanelAlarmTriggerParameters
	{
		///<summary>An optional code to trigger the alarm control panel with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public class AutomationServices
	{
		private readonly IHaContext _haContext;
		public AutomationServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the automation configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("automation", "reload", null);
		}

		///<summary>Toggle (enable / disable) an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("automation", "toggle", target);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void Trigger(ServiceTarget target, AutomationTriggerParameters data)
		{
			_haContext.CallService("automation", "trigger", target, data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public void Trigger(ServiceTarget target, bool? @skipCondition = null)
		{
			_haContext.CallService("automation", "trigger", target, new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target, AutomationTurnOffParameters data)
		{
			_haContext.CallService("automation", "turn_off", target, data);
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public void TurnOff(ServiceTarget target, bool? @stopActions = null)
		{
			_haContext.CallService("automation", "turn_off", target, new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Enable an automation.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("automation", "turn_on", target);
		}
	}

	public record AutomationTriggerParameters
	{
		///<summary>Whether or not the conditions will be skipped.</summary>
		[JsonPropertyName("skip_condition")]
		public bool? SkipCondition { get; init; }
	}

	public record AutomationTurnOffParameters
	{
		///<summary>Stop currently running actions.</summary>
		[JsonPropertyName("stop_actions")]
		public bool? StopActions { get; init; }
	}

	public class ButtonServices
	{
		private readonly IHaContext _haContext;
		public ButtonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Press the button entity.</summary>
		///<param name="target">The target for this service call</param>
		public void Press(ServiceTarget target)
		{
			_haContext.CallService("button", "press", target);
		}
	}

	public class CameraServices
	{
		private readonly IHaContext _haContext;
		public CameraServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Disable the motion detection in a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void DisableMotionDetection(ServiceTarget target)
		{
			_haContext.CallService("camera", "disable_motion_detection", target);
		}

		///<summary>Enable the motion detection in a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void EnableMotionDetection(ServiceTarget target)
		{
			_haContext.CallService("camera", "enable_motion_detection", target);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The target for this service call</param>
		public void PlayStream(ServiceTarget target, CameraPlayStreamParameters data)
		{
			_haContext.CallService("camera", "play_stream", target, data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public void PlayStream(ServiceTarget target, string @mediaPlayer, object? @format = null)
		{
			_haContext.CallService("camera", "play_stream", target, new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The target for this service call</param>
		public void Record(ServiceTarget target, CameraRecordParameters data)
		{
			_haContext.CallService("camera", "record", target, data);
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public void Record(ServiceTarget target, string @filename, long? @duration = null, long? @lookback = null)
		{
			_haContext.CallService("camera", "record", target, new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The target for this service call</param>
		public void Snapshot(ServiceTarget target, CameraSnapshotParameters data)
		{
			_haContext.CallService("camera", "snapshot", target, data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public void Snapshot(ServiceTarget target, string @filename)
		{
			_haContext.CallService("camera", "snapshot", target, new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Turn off camera.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_off", target);
		}

		///<summary>Turn on camera.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("camera", "turn_on", target);
		}
	}

	public record CameraPlayStreamParameters
	{
		///<summary>Name(s) of media player to stream to.</summary>
		[JsonPropertyName("media_player")]
		public string? MediaPlayer { get; init; }

		///<summary>Stream format supported by media player.</summary>
		[JsonPropertyName("format")]
		public object? Format { get; init; }
	}

	public record CameraRecordParameters
	{
		///<summary>Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</summary>
		[JsonPropertyName("filename")]
		public string? Filename { get; init; }

		///<summary>Target recording length.</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }

		///<summary>Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</summary>
		[JsonPropertyName("lookback")]
		public long? Lookback { get; init; }
	}

	public record CameraSnapshotParameters
	{
		///<summary>Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</summary>
		[JsonPropertyName("filename")]
		public string? Filename { get; init; }
	}

	public class CastServices
	{
		private readonly IHaContext _haContext;
		public CastServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Show a Lovelace view on a Chromecast.</summary>
		public void ShowLovelaceView(CastShowLovelaceViewParameters data)
		{
			_haContext.CallService("cast", "show_lovelace_view", null, data);
		}

		///<summary>Show a Lovelace view on a Chromecast.</summary>
		///<param name="entityId">Media Player entity to show the Lovelace view on.</param>
		///<param name="dashboardPath">The URL path of the Lovelace dashboard to show. eg: lovelace-cast</param>
		///<param name="viewPath">The path of the Lovelace view to show. eg: downstairs</param>
		public void ShowLovelaceView(string @entityId, string @dashboardPath, string? @viewPath = null)
		{
			_haContext.CallService("cast", "show_lovelace_view", null, new CastShowLovelaceViewParameters{EntityId = @entityId, DashboardPath = @dashboardPath, ViewPath = @viewPath});
		}
	}

	public record CastShowLovelaceViewParameters
	{
		///<summary>Media Player entity to show the Lovelace view on.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>The URL path of the Lovelace dashboard to show. eg: lovelace-cast</summary>
		[JsonPropertyName("dashboard_path")]
		public string? DashboardPath { get; init; }

		///<summary>The path of the Lovelace view to show. eg: downstairs</summary>
		[JsonPropertyName("view_path")]
		public string? ViewPath { get; init; }
	}

	public class CircadianLightingServices
	{
		private readonly IHaContext _haContext;
		public CircadianLightingServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Updates values for Circadian Lighting.</summary>
		public void ValuesUpdate()
		{
			_haContext.CallService("circadian_lighting", "values_update", null);
		}
	}

	public class ClimateServices
	{
		private readonly IHaContext _haContext;
		public ClimateServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetAuxHeat(ServiceTarget target, ClimateSetAuxHeatParameters data)
		{
			_haContext.CallService("climate", "set_aux_heat", target, data);
		}

		///<summary>Turn auxiliary heater on/off for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="auxHeat">New value of auxiliary heater.</param>
		public void SetAuxHeat(ServiceTarget target, bool @auxHeat)
		{
			_haContext.CallService("climate", "set_aux_heat", target, new ClimateSetAuxHeatParameters{AuxHeat = @auxHeat});
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetFanMode(ServiceTarget target, ClimateSetFanModeParameters data)
		{
			_haContext.CallService("climate", "set_fan_mode", target, data);
		}

		///<summary>Set fan operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="fanMode">New value of fan mode. eg: low</param>
		public void SetFanMode(ServiceTarget target, string @fanMode)
		{
			_haContext.CallService("climate", "set_fan_mode", target, new ClimateSetFanModeParameters{FanMode = @fanMode});
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHumidity(ServiceTarget target, ClimateSetHumidityParameters data)
		{
			_haContext.CallService("climate", "set_humidity", target, data);
		}

		///<summary>Set target humidity of climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="humidity">New target humidity for climate device.</param>
		public void SetHumidity(ServiceTarget target, long @humidity)
		{
			_haContext.CallService("climate", "set_humidity", target, new ClimateSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHvacMode(ServiceTarget target, ClimateSetHvacModeParameters data)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, data);
		}

		///<summary>Set HVAC operation mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="hvacMode">New value of operation mode.</param>
		public void SetHvacMode(ServiceTarget target, object? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_hvac_mode", target, new ClimateSetHvacModeParameters{HvacMode = @hvacMode});
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPresetMode(ServiceTarget target, ClimateSetPresetModeParameters data)
		{
			_haContext.CallService("climate", "set_preset_mode", target, data);
		}

		///<summary>Set preset mode for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="presetMode">New value of preset mode. eg: away</param>
		public void SetPresetMode(ServiceTarget target, string @presetMode)
		{
			_haContext.CallService("climate", "set_preset_mode", target, new ClimateSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetSwingMode(ServiceTarget target, ClimateSetSwingModeParameters data)
		{
			_haContext.CallService("climate", "set_swing_mode", target, data);
		}

		///<summary>Set swing operation for climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="swingMode">New value of swing mode. eg: horizontal</param>
		public void SetSwingMode(ServiceTarget target, string @swingMode)
		{
			_haContext.CallService("climate", "set_swing_mode", target, new ClimateSetSwingModeParameters{SwingMode = @swingMode});
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetTemperature(ServiceTarget target, ClimateSetTemperatureParameters data)
		{
			_haContext.CallService("climate", "set_temperature", target, data);
		}

		///<summary>Set target temperature of climate device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="temperature">New target temperature for HVAC.</param>
		///<param name="targetTempHigh">New target high temperature for HVAC.</param>
		///<param name="targetTempLow">New target low temperature for HVAC.</param>
		///<param name="hvacMode">HVAC operation mode to set temperature to.</param>
		public void SetTemperature(ServiceTarget target, double? @temperature = null, double? @targetTempHigh = null, double? @targetTempLow = null, object? @hvacMode = null)
		{
			_haContext.CallService("climate", "set_temperature", target, new ClimateSetTemperatureParameters{Temperature = @temperature, TargetTempHigh = @targetTempHigh, TargetTempLow = @targetTempLow, HvacMode = @hvacMode});
		}

		///<summary>Turn climate device off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_off", target);
		}

		///<summary>Turn climate device on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("climate", "turn_on", target);
		}
	}

	public record ClimateSetAuxHeatParameters
	{
		///<summary>New value of auxiliary heater.</summary>
		[JsonPropertyName("aux_heat")]
		public bool? AuxHeat { get; init; }
	}

	public record ClimateSetFanModeParameters
	{
		///<summary>New value of fan mode. eg: low</summary>
		[JsonPropertyName("fan_mode")]
		public string? FanMode { get; init; }
	}

	public record ClimateSetHumidityParameters
	{
		///<summary>New target humidity for climate device.</summary>
		[JsonPropertyName("humidity")]
		public long? Humidity { get; init; }
	}

	public record ClimateSetHvacModeParameters
	{
		///<summary>New value of operation mode.</summary>
		[JsonPropertyName("hvac_mode")]
		public object? HvacMode { get; init; }
	}

	public record ClimateSetPresetModeParameters
	{
		///<summary>New value of preset mode. eg: away</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public record ClimateSetSwingModeParameters
	{
		///<summary>New value of swing mode. eg: horizontal</summary>
		[JsonPropertyName("swing_mode")]
		public string? SwingMode { get; init; }
	}

	public record ClimateSetTemperatureParameters
	{
		///<summary>New target temperature for HVAC.</summary>
		[JsonPropertyName("temperature")]
		public double? Temperature { get; init; }

		///<summary>New target high temperature for HVAC.</summary>
		[JsonPropertyName("target_temp_high")]
		public double? TargetTempHigh { get; init; }

		///<summary>New target low temperature for HVAC.</summary>
		[JsonPropertyName("target_temp_low")]
		public double? TargetTempLow { get; init; }

		///<summary>HVAC operation mode to set temperature to.</summary>
		[JsonPropertyName("hvac_mode")]
		public object? HvacMode { get; init; }
	}

	public class CloudServices
	{
		private readonly IHaContext _haContext;
		public CloudServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Make instance UI available outside over NabuCasa cloud</summary>
		public void RemoteConnect()
		{
			_haContext.CallService("cloud", "remote_connect", null);
		}

		///<summary>Disconnect UI from NabuCasa cloud</summary>
		public void RemoteDisconnect()
		{
			_haContext.CallService("cloud", "remote_disconnect", null);
		}
	}

	public class CommandLineServices
	{
		private readonly IHaContext _haContext;
		public CommandLineServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload all command_line entities</summary>
		public void Reload()
		{
			_haContext.CallService("command_line", "reload", null);
		}
	}

	public class CounterServices
	{
		private readonly IHaContext _haContext;
		public CounterServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The target for this service call</param>
		public void Configure(ServiceTarget target, CounterConfigureParameters data)
		{
			_haContext.CallService("counter", "configure", target, data);
		}

		///<summary>Change counter parameters.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="minimum">New minimum value for the counter or None to remove minimum.</param>
		///<param name="maximum">New maximum value for the counter or None to remove maximum.</param>
		///<param name="step">New value for step.</param>
		///<param name="initial">New value for initial.</param>
		///<param name="value">New state value.</param>
		public void Configure(ServiceTarget target, long? @minimum = null, long? @maximum = null, long? @step = null, long? @initial = null, long? @value = null)
		{
			_haContext.CallService("counter", "configure", target, new CounterConfigureParameters{Minimum = @minimum, Maximum = @maximum, Step = @step, Initial = @initial, Value = @value});
		}

		///<summary>Decrement a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Decrement(ServiceTarget target)
		{
			_haContext.CallService("counter", "decrement", target);
		}

		///<summary>Increment a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Increment(ServiceTarget target)
		{
			_haContext.CallService("counter", "increment", target);
		}

		///<summary>Reset a counter.</summary>
		///<param name="target">The target for this service call</param>
		public void Reset(ServiceTarget target)
		{
			_haContext.CallService("counter", "reset", target);
		}
	}

	public record CounterConfigureParameters
	{
		///<summary>New minimum value for the counter or None to remove minimum.</summary>
		[JsonPropertyName("minimum")]
		public long? Minimum { get; init; }

		///<summary>New maximum value for the counter or None to remove maximum.</summary>
		[JsonPropertyName("maximum")]
		public long? Maximum { get; init; }

		///<summary>New value for step.</summary>
		[JsonPropertyName("step")]
		public long? Step { get; init; }

		///<summary>New value for initial.</summary>
		[JsonPropertyName("initial")]
		public long? Initial { get; init; }

		///<summary>New state value.</summary>
		[JsonPropertyName("value")]
		public long? Value { get; init; }
	}

	public class CoverServices
	{
		private readonly IHaContext _haContext;
		public CoverServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Close all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void CloseCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "close_cover", target);
		}

		///<summary>Close all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void CloseCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "close_cover_tilt", target);
		}

		///<summary>Open all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void OpenCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "open_cover", target);
		}

		///<summary>Open all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void OpenCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "open_cover_tilt", target);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void SetCoverPosition(ServiceTarget target, CoverSetCoverPositionParameters data)
		{
			_haContext.CallService("cover", "set_cover_position", target, data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="position">Position of the cover</param>
		public void SetCoverPosition(ServiceTarget target, long @position)
		{
			_haContext.CallService("cover", "set_cover_position", target, new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		public void SetCoverTiltPosition(ServiceTarget target, CoverSetCoverTiltPositionParameters data)
		{
			_haContext.CallService("cover", "set_cover_tilt_position", target, data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public void SetCoverTiltPosition(ServiceTarget target, long @tiltPosition)
		{
			_haContext.CallService("cover", "set_cover_tilt_position", target, new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Stop all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void StopCover(ServiceTarget target)
		{
			_haContext.CallService("cover", "stop_cover", target);
		}

		///<summary>Stop all or specified cover.</summary>
		///<param name="target">The target for this service call</param>
		public void StopCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "stop_cover_tilt", target);
		}

		///<summary>Toggle a cover open/closed.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("cover", "toggle", target);
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		///<param name="target">The target for this service call</param>
		public void ToggleCoverTilt(ServiceTarget target)
		{
			_haContext.CallService("cover", "toggle_cover_tilt", target);
		}
	}

	public record CoverSetCoverPositionParameters
	{
		///<summary>Position of the cover</summary>
		[JsonPropertyName("position")]
		public long? Position { get; init; }
	}

	public record CoverSetCoverTiltPositionParameters
	{
		///<summary>Tilt position of the cover.</summary>
		[JsonPropertyName("tilt_position")]
		public long? TiltPosition { get; init; }
	}

	public class DeviceTrackerServices
	{
		private readonly IHaContext _haContext;
		public DeviceTrackerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Control tracked device.</summary>
		public void See(DeviceTrackerSeeParameters data)
		{
			_haContext.CallService("device_tracker", "see", null, data);
		}

		///<summary>Control tracked device.</summary>
		///<param name="mac">MAC address of device eg: FF:FF:FF:FF:FF:FF</param>
		///<param name="devId">Id of device (find id in known_devices.yaml). eg: phonedave</param>
		///<param name="hostName">Hostname of device eg: Dave</param>
		///<param name="locationName">Name of location where device is located (not_home is away). eg: home</param>
		///<param name="gps">GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</param>
		///<param name="gpsAccuracy">Accuracy of GPS coordinates.</param>
		///<param name="battery">Battery level of device.</param>
		public void See(string? @mac = null, string? @devId = null, string? @hostName = null, string? @locationName = null, object? @gps = null, long? @gpsAccuracy = null, long? @battery = null)
		{
			_haContext.CallService("device_tracker", "see", null, new DeviceTrackerSeeParameters{Mac = @mac, DevId = @devId, HostName = @hostName, LocationName = @locationName, Gps = @gps, GpsAccuracy = @gpsAccuracy, Battery = @battery});
		}
	}

	public record DeviceTrackerSeeParameters
	{
		///<summary>MAC address of device eg: FF:FF:FF:FF:FF:FF</summary>
		[JsonPropertyName("mac")]
		public string? Mac { get; init; }

		///<summary>Id of device (find id in known_devices.yaml). eg: phonedave</summary>
		[JsonPropertyName("dev_id")]
		public string? DevId { get; init; }

		///<summary>Hostname of device eg: Dave</summary>
		[JsonPropertyName("host_name")]
		public string? HostName { get; init; }

		///<summary>Name of location where device is located (not_home is away). eg: home</summary>
		[JsonPropertyName("location_name")]
		public string? LocationName { get; init; }

		///<summary>GPS coordinates where device is located (latitude, longitude). eg: [51.509802, -0.086692]</summary>
		[JsonPropertyName("gps")]
		public object? Gps { get; init; }

		///<summary>Accuracy of GPS coordinates.</summary>
		[JsonPropertyName("gps_accuracy")]
		public long? GpsAccuracy { get; init; }

		///<summary>Battery level of device.</summary>
		[JsonPropertyName("battery")]
		public long? Battery { get; init; }
	}

	public class FanServices
	{
		private readonly IHaContext _haContext;
		public FanServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		public void DecreaseSpeed(ServiceTarget target, FanDecreaseSpeedParameters data)
		{
			_haContext.CallService("fan", "decrease_speed", target, data);
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentageStep">Decrease speed by a percentage.</param>
		public void DecreaseSpeed(ServiceTarget target, long? @percentageStep = null)
		{
			_haContext.CallService("fan", "decrease_speed", target, new FanDecreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		public void IncreaseSpeed(ServiceTarget target, FanIncreaseSpeedParameters data)
		{
			_haContext.CallService("fan", "increase_speed", target, data);
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentageStep">Increase speed by a percentage.</param>
		public void IncreaseSpeed(ServiceTarget target, long? @percentageStep = null)
		{
			_haContext.CallService("fan", "increase_speed", target, new FanIncreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The target for this service call</param>
		public void Oscillate(ServiceTarget target, FanOscillateParameters data)
		{
			_haContext.CallService("fan", "oscillate", target, data);
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="oscillating">Flag to turn on/off oscillation.</param>
		public void Oscillate(ServiceTarget target, bool @oscillating)
		{
			_haContext.CallService("fan", "oscillate", target, new FanOscillateParameters{Oscillating = @oscillating});
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The target for this service call</param>
		public void SetDirection(ServiceTarget target, FanSetDirectionParameters data)
		{
			_haContext.CallService("fan", "set_direction", target, data);
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="direction">The direction to rotate.</param>
		public void SetDirection(ServiceTarget target, object @direction)
		{
			_haContext.CallService("fan", "set_direction", target, new FanSetDirectionParameters{Direction = @direction});
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPercentage(ServiceTarget target, FanSetPercentageParameters data)
		{
			_haContext.CallService("fan", "set_percentage", target, data);
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="percentage">Percentage speed setting.</param>
		public void SetPercentage(ServiceTarget target, long @percentage)
		{
			_haContext.CallService("fan", "set_percentage", target, new FanSetPercentageParameters{Percentage = @percentage});
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetPresetMode(ServiceTarget target, FanSetPresetModeParameters data)
		{
			_haContext.CallService("fan", "set_preset_mode", target, data);
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="presetMode">New value of preset mode. eg: auto</param>
		public void SetPresetMode(ServiceTarget target, string @presetMode)
		{
			_haContext.CallService("fan", "set_preset_mode", target, new FanSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Toggle the fan on/off.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("fan", "toggle", target);
		}

		///<summary>Turn fan off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("fan", "turn_off", target);
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, FanTurnOnParameters data)
		{
			_haContext.CallService("fan", "turn_on", target, data);
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="speed">Speed setting. eg: high</param>
		///<param name="percentage">Percentage speed setting.</param>
		///<param name="presetMode">Preset mode setting. eg: auto</param>
		public void TurnOn(ServiceTarget target, string? @speed = null, long? @percentage = null, string? @presetMode = null)
		{
			_haContext.CallService("fan", "turn_on", target, new FanTurnOnParameters{Speed = @speed, Percentage = @percentage, PresetMode = @presetMode});
		}
	}

	public record FanDecreaseSpeedParameters
	{
		///<summary>Decrease speed by a percentage.</summary>
		[JsonPropertyName("percentage_step")]
		public long? PercentageStep { get; init; }
	}

	public record FanIncreaseSpeedParameters
	{
		///<summary>Increase speed by a percentage.</summary>
		[JsonPropertyName("percentage_step")]
		public long? PercentageStep { get; init; }
	}

	public record FanOscillateParameters
	{
		///<summary>Flag to turn on/off oscillation.</summary>
		[JsonPropertyName("oscillating")]
		public bool? Oscillating { get; init; }
	}

	public record FanSetDirectionParameters
	{
		///<summary>The direction to rotate.</summary>
		[JsonPropertyName("direction")]
		public object? Direction { get; init; }
	}

	public record FanSetPercentageParameters
	{
		///<summary>Percentage speed setting.</summary>
		[JsonPropertyName("percentage")]
		public long? Percentage { get; init; }
	}

	public record FanSetPresetModeParameters
	{
		///<summary>New value of preset mode. eg: auto</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public record FanTurnOnParameters
	{
		///<summary>Speed setting. eg: high</summary>
		[JsonPropertyName("speed")]
		public string? Speed { get; init; }

		///<summary>Percentage speed setting.</summary>
		[JsonPropertyName("percentage")]
		public long? Percentage { get; init; }

		///<summary>Preset mode setting. eg: auto</summary>
		[JsonPropertyName("preset_mode")]
		public string? PresetMode { get; init; }
	}

	public class FrontendServices
	{
		private readonly IHaContext _haContext;
		public FrontendServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload themes from YAML configuration.</summary>
		public void ReloadThemes()
		{
			_haContext.CallService("frontend", "reload_themes", null);
		}

		///<summary>Set a theme unless the client selected per-device theme.</summary>
		public void SetTheme(FrontendSetThemeParameters data)
		{
			_haContext.CallService("frontend", "set_theme", null, data);
		}

		///<summary>Set a theme unless the client selected per-device theme.</summary>
		///<param name="name">Name of a predefined theme eg: default</param>
		///<param name="mode">The mode the theme is for.</param>
		public void SetTheme(object @name, object? @mode = null)
		{
			_haContext.CallService("frontend", "set_theme", null, new FrontendSetThemeParameters{Name = @name, Mode = @mode});
		}
	}

	public record FrontendSetThemeParameters
	{
		///<summary>Name of a predefined theme eg: default</summary>
		[JsonPropertyName("name")]
		public object? Name { get; init; }

		///<summary>The mode the theme is for.</summary>
		[JsonPropertyName("mode")]
		public object? Mode { get; init; }
	}

	public class GroupServices
	{
		private readonly IHaContext _haContext;
		public GroupServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload group configuration, entities, and notify services.</summary>
		public void Reload()
		{
			_haContext.CallService("group", "reload", null);
		}

		///<summary>Remove a user group.</summary>
		public void Remove(GroupRemoveParameters data)
		{
			_haContext.CallService("group", "remove", null, data);
		}

		///<summary>Remove a user group.</summary>
		///<param name="objectId">Group id and part of entity id. eg: test_group</param>
		public void Remove(object @objectId)
		{
			_haContext.CallService("group", "remove", null, new GroupRemoveParameters{ObjectId = @objectId});
		}

		///<summary>Create/Update a user group.</summary>
		public void Set(GroupSetParameters data)
		{
			_haContext.CallService("group", "set", null, data);
		}

		///<summary>Create/Update a user group.</summary>
		///<param name="objectId">Group id and part of entity id. eg: test_group</param>
		///<param name="name">Name of group eg: My test group</param>
		///<param name="icon">Name of icon for the group. eg: mdi:camera</param>
		///<param name="entities">List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1, domain.entity_id2</param>
		///<param name="addEntities">List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</param>
		///<param name="all">Enable this option if the group should only turn on when all entities are on.</param>
		public void Set(string @objectId, string? @name = null, object? @icon = null, object? @entities = null, object? @addEntities = null, bool? @all = null)
		{
			_haContext.CallService("group", "set", null, new GroupSetParameters{ObjectId = @objectId, Name = @name, Icon = @icon, Entities = @entities, AddEntities = @addEntities, All = @all});
		}
	}

	public record GroupRemoveParameters
	{
		///<summary>Group id and part of entity id. eg: test_group</summary>
		[JsonPropertyName("object_id")]
		public object? ObjectId { get; init; }
	}

	public record GroupSetParameters
	{
		///<summary>Group id and part of entity id. eg: test_group</summary>
		[JsonPropertyName("object_id")]
		public string? ObjectId { get; init; }

		///<summary>Name of group eg: My test group</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Name of icon for the group. eg: mdi:camera</summary>
		[JsonPropertyName("icon")]
		public object? Icon { get; init; }

		///<summary>List of all members in the group. Not compatible with 'delta'. eg: domain.entity_id1, domain.entity_id2</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>List of members that will change on group listening. eg: domain.entity_id1, domain.entity_id2</summary>
		[JsonPropertyName("add_entities")]
		public object? AddEntities { get; init; }

		///<summary>Enable this option if the group should only turn on when all entities are on.</summary>
		[JsonPropertyName("all")]
		public bool? All { get; init; }
	}

	public class HassioServices
	{
		private readonly IHaContext _haContext;
		public HassioServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Restart add-on.</summary>
		public void AddonRestart(HassioAddonRestartParameters data)
		{
			_haContext.CallService("hassio", "addon_restart", null, data);
		}

		///<summary>Restart add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonRestart(string @addon)
		{
			_haContext.CallService("hassio", "addon_restart", null, new HassioAddonRestartParameters{Addon = @addon});
		}

		///<summary>Start add-on.</summary>
		public void AddonStart(HassioAddonStartParameters data)
		{
			_haContext.CallService("hassio", "addon_start", null, data);
		}

		///<summary>Start add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonStart(string @addon)
		{
			_haContext.CallService("hassio", "addon_start", null, new HassioAddonStartParameters{Addon = @addon});
		}

		///<summary>Write data to add-on stdin.</summary>
		public void AddonStdin(HassioAddonStdinParameters data)
		{
			_haContext.CallService("hassio", "addon_stdin", null, data);
		}

		///<summary>Write data to add-on stdin.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonStdin(string @addon)
		{
			_haContext.CallService("hassio", "addon_stdin", null, new HassioAddonStdinParameters{Addon = @addon});
		}

		///<summary>Stop add-on.</summary>
		public void AddonStop(HassioAddonStopParameters data)
		{
			_haContext.CallService("hassio", "addon_stop", null, data);
		}

		///<summary>Stop add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonStop(string @addon)
		{
			_haContext.CallService("hassio", "addon_stop", null, new HassioAddonStopParameters{Addon = @addon});
		}

		///<summary>Update add-on. This service should be used with caution since add-on updates can contain breaking changes. It is highly recommended that you review release notes/change logs before updating an add-on.</summary>
		public void AddonUpdate(HassioAddonUpdateParameters data)
		{
			_haContext.CallService("hassio", "addon_update", null, data);
		}

		///<summary>Update add-on. This service should be used with caution since add-on updates can contain breaking changes. It is highly recommended that you review release notes/change logs before updating an add-on.</summary>
		///<param name="addon">The add-on slug. eg: core_ssh</param>
		public void AddonUpdate(string @addon)
		{
			_haContext.CallService("hassio", "addon_update", null, new HassioAddonUpdateParameters{Addon = @addon});
		}

		///<summary>Create a full backup.</summary>
		public void BackupFull(HassioBackupFullParameters data)
		{
			_haContext.CallService("hassio", "backup_full", null, data);
		}

		///<summary>Create a full backup.</summary>
		///<param name="name">Optional (default = current date and time). eg: Backup 1</param>
		///<param name="password">Optional password. eg: password</param>
		///<param name="compressed">Use compressed archives</param>
		public void BackupFull(string? @name = null, string? @password = null, bool? @compressed = null)
		{
			_haContext.CallService("hassio", "backup_full", null, new HassioBackupFullParameters{Name = @name, Password = @password, Compressed = @compressed});
		}

		///<summary>Create a partial backup.</summary>
		public void BackupPartial(HassioBackupPartialParameters data)
		{
			_haContext.CallService("hassio", "backup_partial", null, data);
		}

		///<summary>Create a partial backup.</summary>
		///<param name="homeassistant">Backup Home Assistant settings</param>
		///<param name="addons">Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</param>
		///<param name="folders">Optional list of directories. eg: ["homeassistant","share"]</param>
		///<param name="name">Optional (default = current date and time). eg: Partial backup 1</param>
		///<param name="password">Optional password. eg: password</param>
		///<param name="compressed">Use compressed archives</param>
		public void BackupPartial(bool? @homeassistant = null, object? @addons = null, object? @folders = null, string? @name = null, string? @password = null, bool? @compressed = null)
		{
			_haContext.CallService("hassio", "backup_partial", null, new HassioBackupPartialParameters{Homeassistant = @homeassistant, Addons = @addons, Folders = @folders, Name = @name, Password = @password, Compressed = @compressed});
		}

		///<summary>Reboot the host system.</summary>
		public void HostReboot()
		{
			_haContext.CallService("hassio", "host_reboot", null);
		}

		///<summary>Poweroff the host system.</summary>
		public void HostShutdown()
		{
			_haContext.CallService("hassio", "host_shutdown", null);
		}

		///<summary>Restore from full backup.</summary>
		public void RestoreFull(HassioRestoreFullParameters data)
		{
			_haContext.CallService("hassio", "restore_full", null, data);
		}

		///<summary>Restore from full backup.</summary>
		///<param name="slug">Slug of backup to restore from.</param>
		///<param name="password">Optional password. eg: password</param>
		public void RestoreFull(string @slug, string? @password = null)
		{
			_haContext.CallService("hassio", "restore_full", null, new HassioRestoreFullParameters{Slug = @slug, Password = @password});
		}

		///<summary>Restore from partial backup.</summary>
		public void RestorePartial(HassioRestorePartialParameters data)
		{
			_haContext.CallService("hassio", "restore_partial", null, data);
		}

		///<summary>Restore from partial backup.</summary>
		///<param name="slug">Slug of backup to restore from.</param>
		///<param name="homeassistant">Restore Home Assistant</param>
		///<param name="folders">Optional list of directories. eg: ["homeassistant","share"]</param>
		///<param name="addons">Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</param>
		///<param name="password">Optional password. eg: password</param>
		public void RestorePartial(string @slug, bool? @homeassistant = null, object? @folders = null, object? @addons = null, string? @password = null)
		{
			_haContext.CallService("hassio", "restore_partial", null, new HassioRestorePartialParameters{Slug = @slug, Homeassistant = @homeassistant, Folders = @folders, Addons = @addons, Password = @password});
		}
	}

	public record HassioAddonRestartParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStartParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStdinParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonStopParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioAddonUpdateParameters
	{
		///<summary>The add-on slug. eg: core_ssh</summary>
		[JsonPropertyName("addon")]
		public string? Addon { get; init; }
	}

	public record HassioBackupFullParameters
	{
		///<summary>Optional (default = current date and time). eg: Backup 1</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }

		///<summary>Use compressed archives</summary>
		[JsonPropertyName("compressed")]
		public bool? Compressed { get; init; }
	}

	public record HassioBackupPartialParameters
	{
		///<summary>Backup Home Assistant settings</summary>
		[JsonPropertyName("homeassistant")]
		public bool? Homeassistant { get; init; }

		///<summary>Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</summary>
		[JsonPropertyName("addons")]
		public object? Addons { get; init; }

		///<summary>Optional list of directories. eg: ["homeassistant","share"]</summary>
		[JsonPropertyName("folders")]
		public object? Folders { get; init; }

		///<summary>Optional (default = current date and time). eg: Partial backup 1</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }

		///<summary>Use compressed archives</summary>
		[JsonPropertyName("compressed")]
		public bool? Compressed { get; init; }
	}

	public record HassioRestoreFullParameters
	{
		///<summary>Slug of backup to restore from.</summary>
		[JsonPropertyName("slug")]
		public string? Slug { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public record HassioRestorePartialParameters
	{
		///<summary>Slug of backup to restore from.</summary>
		[JsonPropertyName("slug")]
		public string? Slug { get; init; }

		///<summary>Restore Home Assistant</summary>
		[JsonPropertyName("homeassistant")]
		public bool? Homeassistant { get; init; }

		///<summary>Optional list of directories. eg: ["homeassistant","share"]</summary>
		[JsonPropertyName("folders")]
		public object? Folders { get; init; }

		///<summary>Optional list of add-on slugs. eg: ["core_ssh","core_samba","core_mosquitto"]</summary>
		[JsonPropertyName("addons")]
		public object? Addons { get; init; }

		///<summary>Optional password. eg: password</summary>
		[JsonPropertyName("password")]
		public string? Password { get; init; }
	}

	public class HomeassistantServices
	{
		private readonly IHaContext _haContext;
		public HomeassistantServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Check the Home Assistant configuration files for errors. Errors will be displayed in the Home Assistant log.</summary>
		public void CheckConfig()
		{
			_haContext.CallService("homeassistant", "check_config", null);
		}

		///<summary>Reload a config entry that matches a target.</summary>
		///<param name="target">The target for this service call</param>
		public void ReloadConfigEntry(ServiceTarget target, HomeassistantReloadConfigEntryParameters data)
		{
			_haContext.CallService("homeassistant", "reload_config_entry", target, data);
		}

		///<summary>Reload a config entry that matches a target.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="entryId">A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</param>
		public void ReloadConfigEntry(ServiceTarget target, string? @entryId = null)
		{
			_haContext.CallService("homeassistant", "reload_config_entry", target, new HomeassistantReloadConfigEntryParameters{EntryId = @entryId});
		}

		///<summary>Reload the core configuration.</summary>
		public void ReloadCoreConfig()
		{
			_haContext.CallService("homeassistant", "reload_core_config", null);
		}

		///<summary>Restart the Home Assistant service.</summary>
		public void Restart()
		{
			_haContext.CallService("homeassistant", "restart", null);
		}

		///<summary>Save the persistent states (for entities derived from RestoreEntity) immediately. Maintain the normal periodic saving interval.</summary>
		public void SavePersistentStates()
		{
			_haContext.CallService("homeassistant", "save_persistent_states", null);
		}

		///<summary>Update the Home Assistant location.</summary>
		public void SetLocation(HomeassistantSetLocationParameters data)
		{
			_haContext.CallService("homeassistant", "set_location", null, data);
		}

		///<summary>Update the Home Assistant location.</summary>
		///<param name="latitude">Latitude of your location. eg: 32.87336</param>
		///<param name="longitude">Longitude of your location. eg: 117.22743</param>
		public void SetLocation(string @latitude, string @longitude)
		{
			_haContext.CallService("homeassistant", "set_location", null, new HomeassistantSetLocationParameters{Latitude = @latitude, Longitude = @longitude});
		}

		///<summary>Stop the Home Assistant service.</summary>
		public void Stop()
		{
			_haContext.CallService("homeassistant", "stop", null);
		}

		///<summary>Generic service to toggle devices on/off under any domain</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "toggle", target);
		}

		///<summary>Generic service to turn devices off under any domain.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_off", target);
		}

		///<summary>Generic service to turn devices on under any domain.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "turn_on", target);
		}

		///<summary>Force one or more entities to update its data</summary>
		///<param name="target">The target for this service call</param>
		public void UpdateEntity(ServiceTarget target)
		{
			_haContext.CallService("homeassistant", "update_entity", target);
		}
	}

	public record HomeassistantReloadConfigEntryParameters
	{
		///<summary>A configuration entry id eg: 8955375327824e14ba89e4b29cc3ec9a</summary>
		[JsonPropertyName("entry_id")]
		public string? EntryId { get; init; }
	}

	public record HomeassistantSetLocationParameters
	{
		///<summary>Latitude of your location. eg: 32.87336</summary>
		[JsonPropertyName("latitude")]
		public string? Latitude { get; init; }

		///<summary>Longitude of your location. eg: 117.22743</summary>
		[JsonPropertyName("longitude")]
		public string? Longitude { get; init; }
	}

	public class HueServices
	{
		private readonly IHaContext _haContext;
		public HueServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Activate a Hue scene with more control over the options.</summary>
		///<param name="target">The target for this service call</param>
		public void ActivateScene(ServiceTarget target, HueActivateSceneParameters data)
		{
			_haContext.CallService("hue", "activate_scene", target, data);
		}

		///<summary>Activate a Hue scene with more control over the options.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		///<param name="dynamic">Enable dynamic mode of the scene.</param>
		///<param name="speed">Speed of dynamic palette for this scene</param>
		///<param name="brightness">Set brightness for the scene.</param>
		public void ActivateScene(ServiceTarget target, long? @transition = null, bool? @dynamic = null, long? @speed = null, long? @brightness = null)
		{
			_haContext.CallService("hue", "activate_scene", target, new HueActivateSceneParameters{Transition = @transition, Dynamic = @dynamic, Speed = @speed, Brightness = @brightness});
		}

		///<summary>Activate a hue scene stored in the hue hub.</summary>
		public void HueActivateScene(HueHueActivateSceneParameters data)
		{
			_haContext.CallService("hue", "hue_activate_scene", null, data);
		}

		///<summary>Activate a hue scene stored in the hue hub.</summary>
		///<param name="groupName">Name of hue group/room from the hue app. eg: Living Room</param>
		///<param name="sceneName">Name of hue scene from the hue app. eg: Energize</param>
		///<param name="dynamic">Enable dynamic mode of the scene (V2 bridges and supported scenes only).</param>
		public void HueActivateScene(string? @groupName = null, string? @sceneName = null, bool? @dynamic = null)
		{
			_haContext.CallService("hue", "hue_activate_scene", null, new HueHueActivateSceneParameters{GroupName = @groupName, SceneName = @sceneName, Dynamic = @dynamic});
		}
	}

	public record HueActivateSceneParameters
	{
		///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>Enable dynamic mode of the scene.</summary>
		[JsonPropertyName("dynamic")]
		public bool? Dynamic { get; init; }

		///<summary>Speed of dynamic palette for this scene</summary>
		[JsonPropertyName("speed")]
		public long? Speed { get; init; }

		///<summary>Set brightness for the scene.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }
	}

	public record HueHueActivateSceneParameters
	{
		///<summary>Name of hue group/room from the hue app. eg: Living Room</summary>
		[JsonPropertyName("group_name")]
		public string? GroupName { get; init; }

		///<summary>Name of hue scene from the hue app. eg: Energize</summary>
		[JsonPropertyName("scene_name")]
		public string? SceneName { get; init; }

		///<summary>Enable dynamic mode of the scene (V2 bridges and supported scenes only).</summary>
		[JsonPropertyName("dynamic")]
		public bool? Dynamic { get; init; }
	}

	public class HumidifierServices
	{
		private readonly IHaContext _haContext;
		public HumidifierServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set target humidity of humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetHumidity(ServiceTarget target, HumidifierSetHumidityParameters data)
		{
			_haContext.CallService("humidifier", "set_humidity", target, data);
		}

		///<summary>Set target humidity of humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="humidity">New target humidity for humidifier device.</param>
		public void SetHumidity(ServiceTarget target, long @humidity)
		{
			_haContext.CallService("humidifier", "set_humidity", target, new HumidifierSetHumidityParameters{Humidity = @humidity});
		}

		///<summary>Set mode for humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void SetMode(ServiceTarget target, HumidifierSetModeParameters data)
		{
			_haContext.CallService("humidifier", "set_mode", target, data);
		}

		///<summary>Set mode for humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mode">New mode eg: away</param>
		public void SetMode(ServiceTarget target, string @mode)
		{
			_haContext.CallService("humidifier", "set_mode", target, new HumidifierSetModeParameters{Mode = @mode});
		}

		///<summary>Toggles a humidifier device.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("humidifier", "toggle", target);
		}

		///<summary>Turn humidifier device off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("humidifier", "turn_off", target);
		}

		///<summary>Turn humidifier device on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("humidifier", "turn_on", target);
		}
	}

	public record HumidifierSetHumidityParameters
	{
		///<summary>New target humidity for humidifier device.</summary>
		[JsonPropertyName("humidity")]
		public long? Humidity { get; init; }
	}

	public record HumidifierSetModeParameters
	{
		///<summary>New mode eg: away</summary>
		[JsonPropertyName("mode")]
		public string? Mode { get; init; }
	}

	public class InputBooleanServices
	{
		private readonly IHaContext _haContext;
		public InputBooleanServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_boolean configuration</summary>
		public void Reload()
		{
			_haContext.CallService("input_boolean", "reload", null);
		}

		///<summary>Toggle an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "toggle", target);
		}

		///<summary>Turn off an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "turn_off", target);
		}

		///<summary>Turn on an input boolean</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("input_boolean", "turn_on", target);
		}
	}

	public class InputButtonServices
	{
		private readonly IHaContext _haContext;
		public InputButtonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Press the input button entity.</summary>
		///<param name="target">The target for this service call</param>
		public void Press(ServiceTarget target)
		{
			_haContext.CallService("input_button", "press", target);
		}

		public void Reload()
		{
			_haContext.CallService("input_button", "reload", null);
		}
	}

	public class InputDatetimeServices
	{
		private readonly IHaContext _haContext;
		public InputDatetimeServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_datetime configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_datetime", "reload", null);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The target for this service call</param>
		public void SetDatetime(ServiceTarget target, InputDatetimeSetDatetimeParameters data)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public void SetDatetime(ServiceTarget target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			_haContext.CallService("input_datetime", "set_datetime", target, new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}
	}

	public record InputDatetimeSetDatetimeParameters
	{
		///<summary>The target date the entity should be set to. eg: "2019-04-20"</summary>
		[JsonPropertyName("date")]
		public string? Date { get; init; }

		///<summary>The target time the entity should be set to. eg: "05:04:20"</summary>
		[JsonPropertyName("time")]
		public DateTime? Time { get; init; }

		///<summary>The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</summary>
		[JsonPropertyName("datetime")]
		public string? Datetime { get; init; }

		///<summary>The target date & time the entity should be set to as expressed by a UNIX timestamp.</summary>
		[JsonPropertyName("timestamp")]
		public long? Timestamp { get; init; }
	}

	public class InputNumberServices
	{
		private readonly IHaContext _haContext;
		public InputNumberServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		///<param name="target">The target for this service call</param>
		public void Decrement(ServiceTarget target)
		{
			_haContext.CallService("input_number", "decrement", target);
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		///<param name="target">The target for this service call</param>
		public void Increment(ServiceTarget target)
		{
			_haContext.CallService("input_number", "increment", target);
		}

		///<summary>Reload the input_number configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_number", "reload", null);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, InputNumberSetValueParameters data)
		{
			_haContext.CallService("input_number", "set_value", target, data);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to.</param>
		public void SetValue(ServiceTarget target, double @value)
		{
			_haContext.CallService("input_number", "set_value", target, new InputNumberSetValueParameters{Value = @value});
		}
	}

	public record InputNumberSetValueParameters
	{
		///<summary>The target value the entity should be set to.</summary>
		[JsonPropertyName("value")]
		public double? Value { get; init; }
	}

	public class InputSelectServices
	{
		private readonly IHaContext _haContext;
		public InputSelectServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_select configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_select", "reload", null);
		}

		///<summary>Select the first option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectFirst(ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_first", target);
		}

		///<summary>Select the last option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectLast(ServiceTarget target)
		{
			_haContext.CallService("input_select", "select_last", target);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectNext(ServiceTarget target, InputSelectSelectNextParameters data)
		{
			_haContext.CallService("input_select", "select_next", target, data);
		}

		///<summary>Select the next options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="cycle">If the option should cycle from the last to the first.</param>
		public void SelectNext(ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_next", target, new InputSelectSelectNextParameters{Cycle = @cycle});
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectOption(ServiceTarget target, InputSelectSelectOptionParameters data)
		{
			_haContext.CallService("input_select", "select_option", target, data);
		}

		///<summary>Select an option of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public void SelectOption(ServiceTarget target, string @option)
		{
			_haContext.CallService("input_select", "select_option", target, new InputSelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectPrevious(ServiceTarget target, InputSelectSelectPreviousParameters data)
		{
			_haContext.CallService("input_select", "select_previous", target, data);
		}

		///<summary>Select the previous options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="cycle">If the option should cycle from the first to the last.</param>
		public void SelectPrevious(ServiceTarget target, bool? @cycle = null)
		{
			_haContext.CallService("input_select", "select_previous", target, new InputSelectSelectPreviousParameters{Cycle = @cycle});
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetOptions(ServiceTarget target, InputSelectSetOptionsParameters data)
		{
			_haContext.CallService("input_select", "set_options", target, data);
		}

		///<summary>Set the options of an input select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="options">Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</param>
		public void SetOptions(ServiceTarget target, object @options)
		{
			_haContext.CallService("input_select", "set_options", target, new InputSelectSetOptionsParameters{Options = @options});
		}
	}

	public record InputSelectSelectNextParameters
	{
		///<summary>If the option should cycle from the last to the first.</summary>
		[JsonPropertyName("cycle")]
		public bool? Cycle { get; init; }
	}

	public record InputSelectSelectOptionParameters
	{
		///<summary>Option to be selected. eg: "Item A"</summary>
		[JsonPropertyName("option")]
		public string? Option { get; init; }
	}

	public record InputSelectSelectPreviousParameters
	{
		///<summary>If the option should cycle from the first to the last.</summary>
		[JsonPropertyName("cycle")]
		public bool? Cycle { get; init; }
	}

	public record InputSelectSetOptionsParameters
	{
		///<summary>Options for the input select entity. eg: ["Item A", "Item B", "Item C"]</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public class InputTextServices
	{
		private readonly IHaContext _haContext;
		public InputTextServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the input_text configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("input_text", "reload", null);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, InputTextSetValueParameters data)
		{
			_haContext.CallService("input_text", "set_value", target, data);
		}

		///<summary>Set the value of an input text entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to. eg: This is an example text</param>
		public void SetValue(ServiceTarget target, string @value)
		{
			_haContext.CallService("input_text", "set_value", target, new InputTextSetValueParameters{Value = @value});
		}
	}

	public record InputTextSetValueParameters
	{
		///<summary>The target value the entity should be set to. eg: This is an example text</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public class LightServices
	{
		private readonly IHaContext _haContext;
		public LightServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target, LightToggleParameters data)
		{
			_haContext.CallService("light", "toggle", target, data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public void Toggle(ServiceTarget target, long? @transition = null, object? @rgbColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			_haContext.CallService("light", "toggle", target, new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target, LightTurnOffParameters data)
		{
			_haContext.CallService("light", "turn_off", target, data);
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public void TurnOff(ServiceTarget target, long? @transition = null, object? @flash = null)
		{
			_haContext.CallService("light", "turn_off", target, new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, LightTurnOnParameters data)
		{
			_haContext.CallService("light", "turn_on", target, data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">The color for the light (based on RGB - red, green, blue).</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public void TurnOn(ServiceTarget target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			_haContext.CallService("light", "turn_on", target, new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}
	}

	public record LightToggleParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>Color for the light in RGB-format. eg: [255, 100, 100]</summary>
		[JsonPropertyName("rgb_color")]
		public object? RgbColor { get; init; }

		///<summary>A human readable color name.</summary>
		[JsonPropertyName("color_name")]
		public object? ColorName { get; init; }

		///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
		[JsonPropertyName("hs_color")]
		public object? HsColor { get; init; }

		///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
		[JsonPropertyName("xy_color")]
		public object? XyColor { get; init; }

		///<summary>Color temperature for the light in mireds.</summary>
		[JsonPropertyName("color_temp")]
		public object? ColorTemp { get; init; }

		///<summary>Color temperature for the light in Kelvin.</summary>
		[JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		///<summary>Number indicating level of white.</summary>
		[JsonPropertyName("white_value")]
		public long? WhiteValue { get; init; }

		///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }

		///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness_pct")]
		public long? BrightnessPct { get; init; }

		///<summary>Name of a light profile to use. eg: relax</summary>
		[JsonPropertyName("profile")]
		public string? Profile { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public object? Flash { get; init; }

		///<summary>Light effect.</summary>
		[JsonPropertyName("effect")]
		public string? Effect { get; init; }
	}

	public record LightTurnOffParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public object? Flash { get; init; }
	}

	public record LightTurnOnParameters
	{
		///<summary>Duration it takes to get to next state.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }

		///<summary>The color for the light (based on RGB - red, green, blue).</summary>
		[JsonPropertyName("rgb_color")]
		public object? RgbColor { get; init; }

		///<summary>A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</summary>
		[JsonPropertyName("rgbw_color")]
		public object? RgbwColor { get; init; }

		///<summary>A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</summary>
		[JsonPropertyName("rgbww_color")]
		public object? RgbwwColor { get; init; }

		///<summary>A human readable color name.</summary>
		[JsonPropertyName("color_name")]
		public object? ColorName { get; init; }

		///<summary>Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</summary>
		[JsonPropertyName("hs_color")]
		public object? HsColor { get; init; }

		///<summary>Color for the light in XY-format. eg: [0.52, 0.43]</summary>
		[JsonPropertyName("xy_color")]
		public object? XyColor { get; init; }

		///<summary>Color temperature for the light in mireds.</summary>
		[JsonPropertyName("color_temp")]
		public object? ColorTemp { get; init; }

		///<summary>Color temperature for the light in Kelvin.</summary>
		[JsonPropertyName("kelvin")]
		public long? Kelvin { get; init; }

		///<summary>Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness")]
		public long? Brightness { get; init; }

		///<summary>Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("brightness_pct")]
		public long? BrightnessPct { get; init; }

		///<summary>Change brightness by an amount.</summary>
		[JsonPropertyName("brightness_step")]
		public long? BrightnessStep { get; init; }

		///<summary>Change brightness by a percentage.</summary>
		[JsonPropertyName("brightness_step_pct")]
		public long? BrightnessStepPct { get; init; }

		///<summary>Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</summary>
		[JsonPropertyName("white")]
		public long? White { get; init; }

		///<summary>Name of a light profile to use. eg: relax</summary>
		[JsonPropertyName("profile")]
		public string? Profile { get; init; }

		///<summary>If the light should flash.</summary>
		[JsonPropertyName("flash")]
		public object? Flash { get; init; }

		///<summary>Light effect.</summary>
		[JsonPropertyName("effect")]
		public string? Effect { get; init; }
	}

	public class LockServices
	{
		private readonly IHaContext _haContext;
		public LockServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Lock(ServiceTarget target, LockLockParameters data)
		{
			_haContext.CallService("lock", "lock", target, data);
		}

		///<summary>Lock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to lock the lock with. eg: 1234</param>
		public void Lock(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "lock", target, new LockLockParameters{Code = @code});
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Open(ServiceTarget target, LockOpenParameters data)
		{
			_haContext.CallService("lock", "open", target, data);
		}

		///<summary>Open all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to open the lock with. eg: 1234</param>
		public void Open(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "open", target, new LockOpenParameters{Code = @code});
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		public void Unlock(ServiceTarget target, LockUnlockParameters data)
		{
			_haContext.CallService("lock", "unlock", target, data);
		}

		///<summary>Unlock all or specified locks.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="code">An optional code to unlock the lock with. eg: 1234</param>
		public void Unlock(ServiceTarget target, string? @code = null)
		{
			_haContext.CallService("lock", "unlock", target, new LockUnlockParameters{Code = @code});
		}
	}

	public record LockLockParameters
	{
		///<summary>An optional code to lock the lock with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record LockOpenParameters
	{
		///<summary>An optional code to open the lock with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public record LockUnlockParameters
	{
		///<summary>An optional code to unlock the lock with. eg: 1234</summary>
		[JsonPropertyName("code")]
		public string? Code { get; init; }
	}

	public class LogbookServices
	{
		private readonly IHaContext _haContext;
		public LogbookServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Create a custom entry in your logbook.</summary>
		public void Log(LogbookLogParameters data)
		{
			_haContext.CallService("logbook", "log", null, data);
		}

		///<summary>Create a custom entry in your logbook.</summary>
		///<param name="name">Custom name for an entity, can be referenced with entity_id. eg: Kitchen</param>
		///<param name="message">Message of the custom logbook entry. eg: is being used</param>
		///<param name="entityId">Entity to reference in custom logbook entry.</param>
		///<param name="domain">Icon of domain to display in custom logbook entry. eg: light</param>
		public void Log(string @name, string @message, string? @entityId = null, string? @domain = null)
		{
			_haContext.CallService("logbook", "log", null, new LogbookLogParameters{Name = @name, Message = @message, EntityId = @entityId, Domain = @domain});
		}
	}

	public record LogbookLogParameters
	{
		///<summary>Custom name for an entity, can be referenced with entity_id. eg: Kitchen</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }

		///<summary>Message of the custom logbook entry. eg: is being used</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Entity to reference in custom logbook entry.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Icon of domain to display in custom logbook entry. eg: light</summary>
		[JsonPropertyName("domain")]
		public string? Domain { get; init; }
	}

	public class MediaPlayerServices
	{
		private readonly IHaContext _haContext;
		public MediaPlayerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Send the media player the command to clear players playlist.</summary>
		///<param name="target">The target for this service call</param>
		public void ClearPlaylist(ServiceTarget target)
		{
			_haContext.CallService("media_player", "clear_playlist", target);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		public void Join(ServiceTarget target, MediaPlayerJoinParameters data)
		{
			_haContext.CallService("media_player", "join", target, data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2","media_player.multiroom_player3"]</param>
		public void Join(ServiceTarget target, object? @groupMembers = null)
		{
			_haContext.CallService("media_player", "join", target, new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Send the media player the command for next track.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaNextTrack(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_next_track", target);
		}

		///<summary>Send the media player the command for pause.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPause(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_pause", target);
		}

		///<summary>Send the media player the command for play.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPlay(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_play", target);
		}

		///<summary>Toggle media player play/pause state.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPlayPause(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_play_pause", target);
		}

		///<summary>Send the media player the command for previous track.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaPreviousTrack(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_previous_track", target);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaSeek(ServiceTarget target, MediaPlayerMediaSeekParameters data)
		{
			_haContext.CallService("media_player", "media_seek", target, data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public void MediaSeek(ServiceTarget target, double @seekPosition)
		{
			_haContext.CallService("media_player", "media_seek", target, new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the stop command.</summary>
		///<param name="target">The target for this service call</param>
		public void MediaStop(ServiceTarget target)
		{
			_haContext.CallService("media_player", "media_stop", target);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The target for this service call</param>
		public void PlayMedia(ServiceTarget target, MediaPlayerPlayMediaParameters data)
		{
			_haContext.CallService("media_player", "play_media", target, data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		///<param name="enqueue">If the content should be played now or be added to the queue.</param>
		///<param name="announce">If the media should be played as an announcement. eg: true</param>
		public void PlayMedia(ServiceTarget target, string @mediaContentId, string @mediaContentType, object? @enqueue = null, bool? @announce = null)
		{
			_haContext.CallService("media_player", "play_media", target, new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType, Enqueue = @enqueue, Announce = @announce});
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The target for this service call</param>
		public void RepeatSet(ServiceTarget target, MediaPlayerRepeatSetParameters data)
		{
			_haContext.CallService("media_player", "repeat_set", target, data);
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The target for this service call</param>
		///<param name="repeat">Repeat mode to set.</param>
		public void RepeatSet(ServiceTarget target, object @repeat)
		{
			_haContext.CallService("media_player", "repeat_set", target, new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectSoundMode(ServiceTarget target, MediaPlayerSelectSoundModeParameters data)
		{
			_haContext.CallService("media_player", "select_sound_mode", target, data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public void SelectSoundMode(ServiceTarget target, string? @soundMode = null)
		{
			_haContext.CallService("media_player", "select_sound_mode", target, new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectSource(ServiceTarget target, MediaPlayerSelectSourceParameters data)
		{
			_haContext.CallService("media_player", "select_source", target, data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public void SelectSource(ServiceTarget target, string @source)
		{
			_haContext.CallService("media_player", "select_source", target, new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The target for this service call</param>
		public void ShuffleSet(ServiceTarget target, MediaPlayerShuffleSetParameters data)
		{
			_haContext.CallService("media_player", "shuffle_set", target, data);
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public void ShuffleSet(ServiceTarget target, bool @shuffle)
		{
			_haContext.CallService("media_player", "shuffle_set", target, new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Toggles a media player power state.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("media_player", "toggle", target);
		}

		///<summary>Turn a media player power off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("media_player", "turn_off", target);
		}

		///<summary>Turn a media player power on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("media_player", "turn_on", target);
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		///<param name="target">The target for this service call</param>
		public void Unjoin(ServiceTarget target)
		{
			_haContext.CallService("media_player", "unjoin", target);
		}

		///<summary>Turn a media player volume down.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeDown(ServiceTarget target)
		{
			_haContext.CallService("media_player", "volume_down", target);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeMute(ServiceTarget target, MediaPlayerVolumeMuteParameters data)
		{
			_haContext.CallService("media_player", "volume_mute", target, data);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public void VolumeMute(ServiceTarget target, bool @isVolumeMuted)
		{
			_haContext.CallService("media_player", "volume_mute", target, new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeSet(ServiceTarget target, MediaPlayerVolumeSetParameters data)
		{
			_haContext.CallService("media_player", "volume_set", target, data);
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public void VolumeSet(ServiceTarget target, double @volumeLevel)
		{
			_haContext.CallService("media_player", "volume_set", target, new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Turn a media player volume up.</summary>
		///<param name="target">The target for this service call</param>
		public void VolumeUp(ServiceTarget target)
		{
			_haContext.CallService("media_player", "volume_up", target);
		}
	}

	public record MediaPlayerJoinParameters
	{
		///<summary>The players which will be synced with the target player. eg: ["media_player.multiroom_player2","media_player.multiroom_player3"]</summary>
		[JsonPropertyName("group_members")]
		public object? GroupMembers { get; init; }
	}

	public record MediaPlayerMediaSeekParameters
	{
		///<summary>Position to seek to. The format is platform dependent.</summary>
		[JsonPropertyName("seek_position")]
		public double? SeekPosition { get; init; }
	}

	public record MediaPlayerPlayMediaParameters
	{
		///<summary>The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</summary>
		[JsonPropertyName("media_content_id")]
		public string? MediaContentId { get; init; }

		///<summary>The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</summary>
		[JsonPropertyName("media_content_type")]
		public string? MediaContentType { get; init; }

		///<summary>If the content should be played now or be added to the queue.</summary>
		[JsonPropertyName("enqueue")]
		public object? Enqueue { get; init; }

		///<summary>If the media should be played as an announcement. eg: true</summary>
		[JsonPropertyName("announce")]
		public bool? Announce { get; init; }
	}

	public record MediaPlayerRepeatSetParameters
	{
		///<summary>Repeat mode to set.</summary>
		[JsonPropertyName("repeat")]
		public object? Repeat { get; init; }
	}

	public record MediaPlayerSelectSoundModeParameters
	{
		///<summary>Name of the sound mode to switch to. eg: Music</summary>
		[JsonPropertyName("sound_mode")]
		public string? SoundMode { get; init; }
	}

	public record MediaPlayerSelectSourceParameters
	{
		///<summary>Name of the source to switch to. Platform dependent. eg: video1</summary>
		[JsonPropertyName("source")]
		public string? Source { get; init; }
	}

	public record MediaPlayerShuffleSetParameters
	{
		///<summary>True/false for enabling/disabling shuffle.</summary>
		[JsonPropertyName("shuffle")]
		public bool? Shuffle { get; init; }
	}

	public record MediaPlayerVolumeMuteParameters
	{
		///<summary>True/false for mute/unmute.</summary>
		[JsonPropertyName("is_volume_muted")]
		public bool? IsVolumeMuted { get; init; }
	}

	public record MediaPlayerVolumeSetParameters
	{
		///<summary>Volume level to set as float.</summary>
		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }
	}

	public class MqttServices
	{
		private readonly IHaContext _haContext;
		public MqttServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Dump messages on a topic selector to the 'mqtt_dump.txt' file in your configuration folder.</summary>
		public void Dump(MqttDumpParameters data)
		{
			_haContext.CallService("mqtt", "dump", null, data);
		}

		///<summary>Dump messages on a topic selector to the 'mqtt_dump.txt' file in your configuration folder.</summary>
		///<param name="topic">topic to listen to eg: OpenZWave/#</param>
		///<param name="duration">how long we should listen for messages in seconds</param>
		public void Dump(string? @topic = null, long? @duration = null)
		{
			_haContext.CallService("mqtt", "dump", null, new MqttDumpParameters{Topic = @topic, Duration = @duration});
		}

		///<summary>Publish a message to an MQTT topic.</summary>
		public void Publish(MqttPublishParameters data)
		{
			_haContext.CallService("mqtt", "publish", null, data);
		}

		///<summary>Publish a message to an MQTT topic.</summary>
		///<param name="topic">Topic to publish payload. eg: /homeassistant/hello</param>
		///<param name="payload">Payload to publish. eg: This is great</param>
		///<param name="payloadTemplate">Template to render as payload value. Ignored if payload given. eg: {{ states('sensor.temperature') }}</param>
		///<param name="qos">Quality of Service to use.</param>
		///<param name="retain">If message should have the retain flag set.</param>
		public void Publish(string @topic, string? @payload = null, object? @payloadTemplate = null, object? @qos = null, bool? @retain = null)
		{
			_haContext.CallService("mqtt", "publish", null, new MqttPublishParameters{Topic = @topic, Payload = @payload, PayloadTemplate = @payloadTemplate, Qos = @qos, Retain = @retain});
		}

		///<summary>Reload all MQTT entities from YAML.</summary>
		public void Reload()
		{
			_haContext.CallService("mqtt", "reload", null);
		}
	}

	public record MqttDumpParameters
	{
		///<summary>topic to listen to eg: OpenZWave/#</summary>
		[JsonPropertyName("topic")]
		public string? Topic { get; init; }

		///<summary>how long we should listen for messages in seconds</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }
	}

	public record MqttPublishParameters
	{
		///<summary>Topic to publish payload. eg: /homeassistant/hello</summary>
		[JsonPropertyName("topic")]
		public string? Topic { get; init; }

		///<summary>Payload to publish. eg: This is great</summary>
		[JsonPropertyName("payload")]
		public string? Payload { get; init; }

		///<summary>Template to render as payload value. Ignored if payload given. eg: {{ states('sensor.temperature') }}</summary>
		[JsonPropertyName("payload_template")]
		public object? PayloadTemplate { get; init; }

		///<summary>Quality of Service to use.</summary>
		[JsonPropertyName("qos")]
		public object? Qos { get; init; }

		///<summary>If message should have the retain flag set.</summary>
		[JsonPropertyName("retain")]
		public bool? Retain { get; init; }
	}

	public class MysensorsServices
	{
		private readonly IHaContext _haContext;
		public MysensorsServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set an IR code as a state attribute for a MySensors IR device switch and turn the switch on.</summary>
		public void SendIrCode(MysensorsSendIrCodeParameters data)
		{
			_haContext.CallService("mysensors", "send_ir_code", null, data);
		}

		///<summary>Set an IR code as a state attribute for a MySensors IR device switch and turn the switch on.</summary>
		///<param name="entityId">Name of entity that should have the IR code set and be turned on. Platform dependent.</param>
		///<param name="vIRSEND">IR code to send. eg: 0xC284</param>
		public void SendIrCode(string @vIRSEND, string? @entityId = null)
		{
			_haContext.CallService("mysensors", "send_ir_code", null, new MysensorsSendIrCodeParameters{EntityId = @entityId, VIRSEND = @vIRSEND});
		}
	}

	public record MysensorsSendIrCodeParameters
	{
		///<summary>Name of entity that should have the IR code set and be turned on. Platform dependent.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>IR code to send. eg: 0xC284</summary>
		[JsonPropertyName("V_IR_SEND")]
		public string? VIRSEND { get; init; }
	}

	public class NotifyServices
	{
		private readonly IHaContext _haContext;
		public NotifyServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Sends a notification message using the mobile_app_pixel_6_pro integration.</summary>
		public void MobileAppPixel6Pro(NotifyMobileAppPixel6ProParameters data)
		{
			_haContext.CallService("notify", "mobile_app_pixel_6_pro", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_pixel_6_pro integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppPixel6Pro(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_pixel_6_pro", null, new NotifyMobileAppPixel6ProParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the mobile_app_sm_g973u integration.</summary>
		public void MobileAppSmG973u(NotifyMobileAppSmG973uParameters data)
		{
			_haContext.CallService("notify", "mobile_app_sm_g973u", null, data);
		}

		///<summary>Sends a notification message using the mobile_app_sm_g973u integration.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void MobileAppSmG973u(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "mobile_app_sm_g973u", null, new NotifyMobileAppSmG973uParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification message using the notify service.</summary>
		public void Notify(NotifyNotifyParameters data)
		{
			_haContext.CallService("notify", "notify", null, data);
		}

		///<summary>Sends a notification message using the notify service.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		///<param name="target">An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</param>
		///<param name="data">Extended information for notification. Optional depending on the platform. eg: platform specific</param>
		public void Notify(string @message, string? @title = null, object? @target = null, object? @data = null)
		{
			_haContext.CallService("notify", "notify", null, new NotifyNotifyParameters{Message = @message, Title = @title, Target = @target, Data = @data});
		}

		///<summary>Sends a notification that is visible in the front-end.</summary>
		public void PersistentNotification(NotifyPersistentNotificationParameters data)
		{
			_haContext.CallService("notify", "persistent_notification", null, data);
		}

		///<summary>Sends a notification that is visible in the front-end.</summary>
		///<param name="message">Message body of the notification. eg: The garage door has been open for 10 minutes.</param>
		///<param name="title">Title for your notification. eg: Your Garage Door Friend</param>
		public void PersistentNotification(string @message, string? @title = null)
		{
			_haContext.CallService("notify", "persistent_notification", null, new NotifyPersistentNotificationParameters{Message = @message, Title = @title});
		}
	}

	public record NotifyMobileAppPixel6ProParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyMobileAppSmG973uParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyNotifyParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>An array of targets to send the notification to. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("target")]
		public object? Target { get; init; }

		///<summary>Extended information for notification. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("data")]
		public object? Data { get; init; }
	}

	public record NotifyPersistentNotificationParameters
	{
		///<summary>Message body of the notification. eg: The garage door has been open for 10 minutes.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Title for your notification. eg: Your Garage Door Friend</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }
	}

	public class NumberServices
	{
		private readonly IHaContext _haContext;
		public NumberServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, NumberSetValueParameters data)
		{
			_haContext.CallService("number", "set_value", target, data);
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="value">The target value the entity should be set to. eg: 42</param>
		public void SetValue(ServiceTarget target, string? @value = null)
		{
			_haContext.CallService("number", "set_value", target, new NumberSetValueParameters{Value = @value});
		}
	}

	public record NumberSetValueParameters
	{
		///<summary>The target value the entity should be set to. eg: 42</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public class PersistentNotificationServices
	{
		private readonly IHaContext _haContext;
		public PersistentNotificationServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Show a notification in the frontend.</summary>
		public void Create(PersistentNotificationCreateParameters data)
		{
			_haContext.CallService("persistent_notification", "create", null, data);
		}

		///<summary>Show a notification in the frontend.</summary>
		///<param name="message">Message body of the notification. [Templates accepted] eg: Please check your configuration.yaml.</param>
		///<param name="title">Optional title for your notification. [Templates accepted] eg: Test notification</param>
		///<param name="notificationId">Target ID of the notification, will replace a notification with the same ID. eg: 1234</param>
		public void Create(string @message, string? @title = null, string? @notificationId = null)
		{
			_haContext.CallService("persistent_notification", "create", null, new PersistentNotificationCreateParameters{Message = @message, Title = @title, NotificationId = @notificationId});
		}

		///<summary>Remove a notification from the frontend.</summary>
		public void Dismiss(PersistentNotificationDismissParameters data)
		{
			_haContext.CallService("persistent_notification", "dismiss", null, data);
		}

		///<summary>Remove a notification from the frontend.</summary>
		///<param name="notificationId">Target ID of the notification, which should be removed. eg: 1234</param>
		public void Dismiss(string @notificationId)
		{
			_haContext.CallService("persistent_notification", "dismiss", null, new PersistentNotificationDismissParameters{NotificationId = @notificationId});
		}

		///<summary>Mark a notification read.</summary>
		public void MarkRead(PersistentNotificationMarkReadParameters data)
		{
			_haContext.CallService("persistent_notification", "mark_read", null, data);
		}

		///<summary>Mark a notification read.</summary>
		///<param name="notificationId">Target ID of the notification, which should be mark read. eg: 1234</param>
		public void MarkRead(string @notificationId)
		{
			_haContext.CallService("persistent_notification", "mark_read", null, new PersistentNotificationMarkReadParameters{NotificationId = @notificationId});
		}
	}

	public record PersistentNotificationCreateParameters
	{
		///<summary>Message body of the notification. [Templates accepted] eg: Please check your configuration.yaml.</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Optional title for your notification. [Templates accepted] eg: Test notification</summary>
		[JsonPropertyName("title")]
		public string? Title { get; init; }

		///<summary>Target ID of the notification, will replace a notification with the same ID. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public record PersistentNotificationDismissParameters
	{
		///<summary>Target ID of the notification, which should be removed. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public record PersistentNotificationMarkReadParameters
	{
		///<summary>Target ID of the notification, which should be mark read. eg: 1234</summary>
		[JsonPropertyName("notification_id")]
		public string? NotificationId { get; init; }
	}

	public class PersonServices
	{
		private readonly IHaContext _haContext;
		public PersonServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the person configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("person", "reload", null);
		}
	}

	public class RecorderServices
	{
		private readonly IHaContext _haContext;
		public RecorderServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Stop the recording of events and state changes</summary>
		public void Disable()
		{
			_haContext.CallService("recorder", "disable", null);
		}

		///<summary>Start the recording of events and state changes</summary>
		public void Enable()
		{
			_haContext.CallService("recorder", "enable", null);
		}

		///<summary>Start purge task - to clean up old data from your database.</summary>
		public void Purge(RecorderPurgeParameters data)
		{
			_haContext.CallService("recorder", "purge", null, data);
		}

		///<summary>Start purge task - to clean up old data from your database.</summary>
		///<param name="keepDays">Number of history days to keep in database after purge.</param>
		///<param name="repack">Attempt to save disk space by rewriting the entire database file.</param>
		///<param name="applyFilter">Apply entity_id and event_type filter in addition to time based purge.</param>
		public void Purge(long? @keepDays = null, bool? @repack = null, bool? @applyFilter = null)
		{
			_haContext.CallService("recorder", "purge", null, new RecorderPurgeParameters{KeepDays = @keepDays, Repack = @repack, ApplyFilter = @applyFilter});
		}

		///<summary>Start purge task to remove specific entities from your database.</summary>
		///<param name="target">The target for this service call</param>
		public void PurgeEntities(ServiceTarget target, RecorderPurgeEntitiesParameters data)
		{
			_haContext.CallService("recorder", "purge_entities", target, data);
		}

		///<summary>Start purge task to remove specific entities from your database.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="domains">List the domains that need to be removed from the recorder database. eg: sun</param>
		///<param name="entityGlobs">List the glob patterns to select entities for removal from the recorder database. eg: domain*.object_id*</param>
		public void PurgeEntities(ServiceTarget target, object? @domains = null, object? @entityGlobs = null)
		{
			_haContext.CallService("recorder", "purge_entities", target, new RecorderPurgeEntitiesParameters{Domains = @domains, EntityGlobs = @entityGlobs});
		}
	}

	public record RecorderPurgeParameters
	{
		///<summary>Number of history days to keep in database after purge.</summary>
		[JsonPropertyName("keep_days")]
		public long? KeepDays { get; init; }

		///<summary>Attempt to save disk space by rewriting the entire database file.</summary>
		[JsonPropertyName("repack")]
		public bool? Repack { get; init; }

		///<summary>Apply entity_id and event_type filter in addition to time based purge.</summary>
		[JsonPropertyName("apply_filter")]
		public bool? ApplyFilter { get; init; }
	}

	public record RecorderPurgeEntitiesParameters
	{
		///<summary>List the domains that need to be removed from the recorder database. eg: sun</summary>
		[JsonPropertyName("domains")]
		public object? Domains { get; init; }

		///<summary>List the glob patterns to select entities for removal from the recorder database. eg: domain*.object_id*</summary>
		[JsonPropertyName("entity_globs")]
		public object? EntityGlobs { get; init; }
	}

	public class SceneServices
	{
		private readonly IHaContext _haContext;
		public SceneServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Activate a scene with configuration.</summary>
		public void Apply(SceneApplyParameters data)
		{
			_haContext.CallService("scene", "apply", null, data);
		}

		///<summary>Activate a scene with configuration.</summary>
		///<param name="entities">The entities and the state that they need to be. eg: {"light.kitchen":"on","light.ceiling":{"state":"on","brightness":80}}</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public void Apply(object @entities, long? @transition = null)
		{
			_haContext.CallService("scene", "apply", null, new SceneApplyParameters{Entities = @entities, Transition = @transition});
		}

		///<summary>Creates a new scene.</summary>
		public void Create(SceneCreateParameters data)
		{
			_haContext.CallService("scene", "create", null, data);
		}

		///<summary>Creates a new scene.</summary>
		///<param name="sceneId">The entity_id of the new scene. eg: all_lights</param>
		///<param name="entities">The entities to control with the scene. eg: {"light.tv_back_light":"on","light.ceiling":{"state":"on","brightness":200}}</param>
		///<param name="snapshotEntities">The entities of which a snapshot is to be taken eg: ["light.ceiling","light.kitchen"]</param>
		public void Create(string @sceneId, object? @entities = null, object? @snapshotEntities = null)
		{
			_haContext.CallService("scene", "create", null, new SceneCreateParameters{SceneId = @sceneId, Entities = @entities, SnapshotEntities = @snapshotEntities});
		}

		///<summary>Reload the scene configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("scene", "reload", null);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, SceneTurnOnParameters data)
		{
			_haContext.CallService("scene", "turn_on", target, data);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public void TurnOn(ServiceTarget target, long? @transition = null)
		{
			_haContext.CallService("scene", "turn_on", target, new SceneTurnOnParameters{Transition = @transition});
		}
	}

	public record SceneApplyParameters
	{
		///<summary>The entities and the state that they need to be. eg: {"light.kitchen":"on","light.ceiling":{"state":"on","brightness":80}}</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }
	}

	public record SceneCreateParameters
	{
		///<summary>The entity_id of the new scene. eg: all_lights</summary>
		[JsonPropertyName("scene_id")]
		public string? SceneId { get; init; }

		///<summary>The entities to control with the scene. eg: {"light.tv_back_light":"on","light.ceiling":{"state":"on","brightness":200}}</summary>
		[JsonPropertyName("entities")]
		public object? Entities { get; init; }

		///<summary>The entities of which a snapshot is to be taken eg: ["light.ceiling","light.kitchen"]</summary>
		[JsonPropertyName("snapshot_entities")]
		public object? SnapshotEntities { get; init; }
	}

	public record SceneTurnOnParameters
	{
		///<summary>Transition duration it takes to bring devices to the state defined in the scene.</summary>
		[JsonPropertyName("transition")]
		public long? Transition { get; init; }
	}

	public class ScriptServices
	{
		private readonly IHaContext _haContext;
		public ScriptServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		public void KCenter()
		{
			_haContext.CallService("script", "k_center", null);
		}

		public void KDown()
		{
			_haContext.CallService("script", "k_down", null);
		}

		public void KLeft()
		{
			_haContext.CallService("script", "k_left", null);
		}

		public void KRight()
		{
			_haContext.CallService("script", "k_right", null);
		}

		public void KUp()
		{
			_haContext.CallService("script", "k_up", null);
		}

		///<summary>Reload all the available scripts</summary>
		public void Reload()
		{
			_haContext.CallService("script", "reload", null);
		}

		///<summary>Toggle script</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("script", "toggle", target);
		}

		///<summary>Turn off script</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("script", "turn_off", target);
		}

		///<summary>Turn on script</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("script", "turn_on", target);
		}
	}

	public class SelectServices
	{
		private readonly IHaContext _haContext;
		public SelectServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The target for this service call</param>
		public void SelectOption(ServiceTarget target, SelectSelectOptionParameters data)
		{
			_haContext.CallService("select", "select_option", target, data);
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public void SelectOption(ServiceTarget target, string @option)
		{
			_haContext.CallService("select", "select_option", target, new SelectSelectOptionParameters{Option = @option});
		}
	}

	public record SelectSelectOptionParameters
	{
		///<summary>Option to be selected. eg: "Item A"</summary>
		[JsonPropertyName("option")]
		public string? Option { get; init; }
	}

	public class ShoppingListServices
	{
		private readonly IHaContext _haContext;
		public ShoppingListServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Add an item to the shopping list.</summary>
		public void AddItem(ShoppingListAddItemParameters data)
		{
			_haContext.CallService("shopping_list", "add_item", null, data);
		}

		///<summary>Add an item to the shopping list.</summary>
		///<param name="name">The name of the item to add. eg: Beer</param>
		public void AddItem(string @name)
		{
			_haContext.CallService("shopping_list", "add_item", null, new ShoppingListAddItemParameters{Name = @name});
		}

		///<summary>Clear completed items from the shopping list.</summary>
		public void ClearCompletedItems()
		{
			_haContext.CallService("shopping_list", "clear_completed_items", null);
		}

		///<summary>Marks all items as completed in the shopping list. It does not remove the items.</summary>
		public void CompleteAll()
		{
			_haContext.CallService("shopping_list", "complete_all", null);
		}

		///<summary>Mark an item as completed in the shopping list.</summary>
		public void CompleteItem(ShoppingListCompleteItemParameters data)
		{
			_haContext.CallService("shopping_list", "complete_item", null, data);
		}

		///<summary>Mark an item as completed in the shopping list.</summary>
		///<param name="name">The name of the item to mark as completed (without removing). eg: Beer</param>
		public void CompleteItem(string @name)
		{
			_haContext.CallService("shopping_list", "complete_item", null, new ShoppingListCompleteItemParameters{Name = @name});
		}

		///<summary>Marks all items as incomplete in the shopping list.</summary>
		public void IncompleteAll()
		{
			_haContext.CallService("shopping_list", "incomplete_all", null);
		}

		///<summary>Marks an item as incomplete in the shopping list.</summary>
		public void IncompleteItem(ShoppingListIncompleteItemParameters data)
		{
			_haContext.CallService("shopping_list", "incomplete_item", null, data);
		}

		///<summary>Marks an item as incomplete in the shopping list.</summary>
		///<param name="name">The name of the item to mark as incomplete. eg: Beer</param>
		public void IncompleteItem(string @name)
		{
			_haContext.CallService("shopping_list", "incomplete_item", null, new ShoppingListIncompleteItemParameters{Name = @name});
		}
	}

	public record ShoppingListAddItemParameters
	{
		///<summary>The name of the item to add. eg: Beer</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }
	}

	public record ShoppingListCompleteItemParameters
	{
		///<summary>The name of the item to mark as completed (without removing). eg: Beer</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }
	}

	public record ShoppingListIncompleteItemParameters
	{
		///<summary>The name of the item to mark as incomplete. eg: Beer</summary>
		[JsonPropertyName("name")]
		public string? Name { get; init; }
	}

	public class SirenServices
	{
		private readonly IHaContext _haContext;
		public SirenServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles a siren.</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("siren", "toggle", target);
		}

		///<summary>Turn siren off.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("siren", "turn_off", target);
		}

		///<summary>Turn siren on.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target, SirenTurnOnParameters data)
		{
			_haContext.CallService("siren", "turn_on", target, data);
		}

		///<summary>Turn siren on.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="tone">The tone to emit when turning the siren on. When `available_tones` property is a map, either the key or the value can be used. Must be supported by the integration. eg: fire</param>
		///<param name="volumeLevel">The volume level of the noise to emit when turning the siren on. Must be supported by the integration. eg: 0.5</param>
		///<param name="duration">The duration in seconds of the noise to emit when turning the siren on. Must be supported by the integration. eg: 15</param>
		public void TurnOn(ServiceTarget target, string? @tone = null, double? @volumeLevel = null, string? @duration = null)
		{
			_haContext.CallService("siren", "turn_on", target, new SirenTurnOnParameters{Tone = @tone, VolumeLevel = @volumeLevel, Duration = @duration});
		}
	}

	public record SirenTurnOnParameters
	{
		///<summary>The tone to emit when turning the siren on. When `available_tones` property is a map, either the key or the value can be used. Must be supported by the integration. eg: fire</summary>
		[JsonPropertyName("tone")]
		public string? Tone { get; init; }

		///<summary>The volume level of the noise to emit when turning the siren on. Must be supported by the integration. eg: 0.5</summary>
		[JsonPropertyName("volume_level")]
		public double? VolumeLevel { get; init; }

		///<summary>The duration in seconds of the noise to emit when turning the siren on. Must be supported by the integration. eg: 15</summary>
		[JsonPropertyName("duration")]
		public string? Duration { get; init; }
	}

	public class SwitchServices
	{
		private readonly IHaContext _haContext;
		public SwitchServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Toggles a switch state</summary>
		///<param name="target">The target for this service call</param>
		public void Toggle(ServiceTarget target)
		{
			_haContext.CallService("switch", "toggle", target);
		}

		///<summary>Turn a switch off</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("switch", "turn_off", target);
		}

		///<summary>Turn a switch on</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("switch", "turn_on", target);
		}
	}

	public class SystemLogServices
	{
		private readonly IHaContext _haContext;
		public SystemLogServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Clear all log entries.</summary>
		public void Clear()
		{
			_haContext.CallService("system_log", "clear", null);
		}

		///<summary>Write log entry.</summary>
		public void Write(SystemLogWriteParameters data)
		{
			_haContext.CallService("system_log", "write", null, data);
		}

		///<summary>Write log entry.</summary>
		///<param name="message">Message to log. eg: Something went wrong</param>
		///<param name="level">Log level.</param>
		///<param name="logger">Logger name under which to log the message. Defaults to 'system_log.external'. eg: mycomponent.myplatform</param>
		public void Write(string @message, object? @level = null, string? @logger = null)
		{
			_haContext.CallService("system_log", "write", null, new SystemLogWriteParameters{Message = @message, Level = @level, Logger = @logger});
		}
	}

	public record SystemLogWriteParameters
	{
		///<summary>Message to log. eg: Something went wrong</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Log level.</summary>
		[JsonPropertyName("level")]
		public object? Level { get; init; }

		///<summary>Logger name under which to log the message. Defaults to 'system_log.external'. eg: mycomponent.myplatform</summary>
		[JsonPropertyName("logger")]
		public string? Logger { get; init; }
	}

	public class TemplateServices
	{
		private readonly IHaContext _haContext;
		public TemplateServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload all template entities.</summary>
		public void Reload()
		{
			_haContext.CallService("template", "reload", null);
		}
	}

	public class TimerServices
	{
		private readonly IHaContext _haContext;
		public TimerServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Cancel a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Cancel(ServiceTarget target)
		{
			_haContext.CallService("timer", "cancel", target);
		}

		///<summary>Finish a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Finish(ServiceTarget target)
		{
			_haContext.CallService("timer", "finish", target);
		}

		///<summary>Pause a timer.</summary>
		///<param name="target">The target for this service call</param>
		public void Pause(ServiceTarget target)
		{
			_haContext.CallService("timer", "pause", target);
		}

		public void Reload()
		{
			_haContext.CallService("timer", "reload", null);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The target for this service call</param>
		public void Start(ServiceTarget target, TimerStartParameters data)
		{
			_haContext.CallService("timer", "start", target, data);
		}

		///<summary>Start a timer</summary>
		///<param name="target">The target for this service call</param>
		///<param name="duration">Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</param>
		public void Start(ServiceTarget target, string? @duration = null)
		{
			_haContext.CallService("timer", "start", target, new TimerStartParameters{Duration = @duration});
		}
	}

	public record TimerStartParameters
	{
		///<summary>Duration the timer requires to finish. [optional] eg: 00:01:00 or 60</summary>
		[JsonPropertyName("duration")]
		public string? Duration { get; init; }
	}

	public class TtsServices
	{
		private readonly IHaContext _haContext;
		public TtsServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Remove all text-to-speech cache files and RAM cache.</summary>
		public void ClearCache()
		{
			_haContext.CallService("tts", "clear_cache", null);
		}

		///<summary>Say something using text-to-speech on a media player with cloud.</summary>
		public void CloudSay(TtsCloudSayParameters data)
		{
			_haContext.CallService("tts", "cloud_say", null, data);
		}

		///<summary>Say something using text-to-speech on a media player with cloud.</summary>
		///<param name="entityId">Name(s) of media player entities.</param>
		///<param name="message">Text to speak on devices. eg: My name is hanna</param>
		///<param name="cache">Control file cache of this message.</param>
		///<param name="language">Language to use for speech generation. eg: ru</param>
		///<param name="options">A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</param>
		public void CloudSay(string @entityId, string @message, bool? @cache = null, string? @language = null, object? @options = null)
		{
			_haContext.CallService("tts", "cloud_say", null, new TtsCloudSayParameters{EntityId = @entityId, Message = @message, Cache = @cache, Language = @language, Options = @options});
		}

		///<summary>Say something using text-to-speech on a media player with google_translate.</summary>
		public void GoogleTranslateSay(TtsGoogleTranslateSayParameters data)
		{
			_haContext.CallService("tts", "google_translate_say", null, data);
		}

		///<summary>Say something using text-to-speech on a media player with google_translate.</summary>
		///<param name="entityId">Name(s) of media player entities.</param>
		///<param name="message">Text to speak on devices. eg: My name is hanna</param>
		///<param name="cache">Control file cache of this message.</param>
		///<param name="language">Language to use for speech generation. eg: ru</param>
		///<param name="options">A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</param>
		public void GoogleTranslateSay(string @entityId, string @message, bool? @cache = null, string? @language = null, object? @options = null)
		{
			_haContext.CallService("tts", "google_translate_say", null, new TtsGoogleTranslateSayParameters{EntityId = @entityId, Message = @message, Cache = @cache, Language = @language, Options = @options});
		}
	}

	public record TtsCloudSayParameters
	{
		///<summary>Name(s) of media player entities.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Text to speak on devices. eg: My name is hanna</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Control file cache of this message.</summary>
		[JsonPropertyName("cache")]
		public bool? Cache { get; init; }

		///<summary>Language to use for speech generation. eg: ru</summary>
		[JsonPropertyName("language")]
		public string? Language { get; init; }

		///<summary>A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public record TtsGoogleTranslateSayParameters
	{
		///<summary>Name(s) of media player entities.</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Text to speak on devices. eg: My name is hanna</summary>
		[JsonPropertyName("message")]
		public string? Message { get; init; }

		///<summary>Control file cache of this message.</summary>
		[JsonPropertyName("cache")]
		public bool? Cache { get; init; }

		///<summary>Language to use for speech generation. eg: ru</summary>
		[JsonPropertyName("language")]
		public string? Language { get; init; }

		///<summary>A dictionary containing platform-specific options. Optional depending on the platform. eg: platform specific</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }
	}

	public class UpdateServices
	{
		private readonly IHaContext _haContext;
		public UpdateServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Removes the skipped version marker from an update.</summary>
		///<param name="target">The target for this service call</param>
		public void ClearSkipped(ServiceTarget target)
		{
			_haContext.CallService("update", "clear_skipped", target);
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The target for this service call</param>
		public void Install(ServiceTarget target, UpdateInstallParameters data)
		{
			_haContext.CallService("update", "install", target, data);
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The target for this service call</param>
		///<param name="version">Version to install, if omitted, the latest version will be installed. eg: 1.0.0</param>
		///<param name="backup">Backup before installing the update, if supported by the integration.</param>
		public void Install(ServiceTarget target, string? @version = null, bool? @backup = null)
		{
			_haContext.CallService("update", "install", target, new UpdateInstallParameters{Version = @version, Backup = @backup});
		}

		///<summary>Mark currently available update as skipped.</summary>
		///<param name="target">The target for this service call</param>
		public void Skip(ServiceTarget target)
		{
			_haContext.CallService("update", "skip", target);
		}
	}

	public record UpdateInstallParameters
	{
		///<summary>Version to install, if omitted, the latest version will be installed. eg: 1.0.0</summary>
		[JsonPropertyName("version")]
		public string? Version { get; init; }

		///<summary>Backup before installing the update, if supported by the integration.</summary>
		[JsonPropertyName("backup")]
		public bool? Backup { get; init; }
	}

	public class VacuumServices
	{
		private readonly IHaContext _haContext;
		public VacuumServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Tell the vacuum cleaner to do a spot clean-up.</summary>
		///<param name="target">The target for this service call</param>
		public void CleanSpot(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "clean_spot", target);
		}

		///<summary>Locate the vacuum cleaner robot.</summary>
		///<param name="target">The target for this service call</param>
		public void Locate(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "locate", target);
		}

		///<summary>Pause the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Pause(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "pause", target);
		}

		///<summary>Tell the vacuum cleaner to return to its dock.</summary>
		///<param name="target">The target for this service call</param>
		public void ReturnToBase(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "return_to_base", target);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void SendCommand(ServiceTarget target, VacuumSendCommandParameters data)
		{
			_haContext.CallService("vacuum", "send_command", target, data);
		}

		///<summary>Send a raw command to the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="command">Command to execute. eg: set_dnd_timer</param>
		///<param name="params">Parameters for the command. eg: { "key": "value" }</param>
		public void SendCommand(ServiceTarget target, string @command, object? @params = null)
		{
			_haContext.CallService("vacuum", "send_command", target, new VacuumSendCommandParameters{Command = @command, Params = @params});
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		public void SetFanSpeed(ServiceTarget target, VacuumSetFanSpeedParameters data)
		{
			_haContext.CallService("vacuum", "set_fan_speed", target, data);
		}

		///<summary>Set the fan speed of the vacuum cleaner.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="fanSpeed">Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</param>
		public void SetFanSpeed(ServiceTarget target, string @fanSpeed)
		{
			_haContext.CallService("vacuum", "set_fan_speed", target, new VacuumSetFanSpeedParameters{FanSpeed = @fanSpeed});
		}

		///<summary>Start or resume the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Start(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "start", target);
		}

		///<summary>Start, pause, or resume the cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void StartPause(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "start_pause", target);
		}

		///<summary>Stop the current cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void Stop(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "stop", target);
		}

		public void Toggle()
		{
			_haContext.CallService("vacuum", "toggle", null);
		}

		///<summary>Stop the current cleaning task and return to home.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOff(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "turn_off", target);
		}

		///<summary>Start a new cleaning task.</summary>
		///<param name="target">The target for this service call</param>
		public void TurnOn(ServiceTarget target)
		{
			_haContext.CallService("vacuum", "turn_on", target);
		}
	}

	public record VacuumSendCommandParameters
	{
		///<summary>Command to execute. eg: set_dnd_timer</summary>
		[JsonPropertyName("command")]
		public string? Command { get; init; }

		///<summary>Parameters for the command. eg: { "key": "value" }</summary>
		[JsonPropertyName("params")]
		public object? Params { get; init; }
	}

	public record VacuumSetFanSpeedParameters
	{
		///<summary>Platform dependent vacuum cleaner fan speed, with speed steps, like 'medium' or by percentage, between 0 and 100. eg: low</summary>
		[JsonPropertyName("fan_speed")]
		public string? FanSpeed { get; init; }
	}

	public class ZhaServices
	{
		private readonly IHaContext _haContext;
		public ZhaServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Clear a user code from a lock</summary>
		///<param name="target">The target for this service call</param>
		public void ClearLockUserCode(ServiceTarget target, ZhaClearLockUserCodeParameters data)
		{
			_haContext.CallService("zha", "clear_lock_user_code", target, data);
		}

		///<summary>Clear a user code from a lock</summary>
		///<param name="target">The target for this service call</param>
		///<param name="codeSlot">Code slot to clear code from eg: 1</param>
		public void ClearLockUserCode(ServiceTarget target, string @codeSlot)
		{
			_haContext.CallService("zha", "clear_lock_user_code", target, new ZhaClearLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Disable a user code on a lock</summary>
		///<param name="target">The target for this service call</param>
		public void DisableLockUserCode(ServiceTarget target, ZhaDisableLockUserCodeParameters data)
		{
			_haContext.CallService("zha", "disable_lock_user_code", target, data);
		}

		///<summary>Disable a user code on a lock</summary>
		///<param name="target">The target for this service call</param>
		///<param name="codeSlot">Code slot to disable eg: 1</param>
		public void DisableLockUserCode(ServiceTarget target, string @codeSlot)
		{
			_haContext.CallService("zha", "disable_lock_user_code", target, new ZhaDisableLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Enable a user code on a lock</summary>
		///<param name="target">The target for this service call</param>
		public void EnableLockUserCode(ServiceTarget target, ZhaEnableLockUserCodeParameters data)
		{
			_haContext.CallService("zha", "enable_lock_user_code", target, data);
		}

		///<summary>Enable a user code on a lock</summary>
		///<param name="target">The target for this service call</param>
		///<param name="codeSlot">Code slot to enable eg: 1</param>
		public void EnableLockUserCode(ServiceTarget target, string @codeSlot)
		{
			_haContext.CallService("zha", "enable_lock_user_code", target, new ZhaEnableLockUserCodeParameters{CodeSlot = @codeSlot});
		}

		///<summary>Issue command on the specified cluster on the specified entity.</summary>
		public void IssueZigbeeClusterCommand(ZhaIssueZigbeeClusterCommandParameters data)
		{
			_haContext.CallService("zha", "issue_zigbee_cluster_command", null, data);
		}

		///<summary>Issue command on the specified cluster on the specified entity.</summary>
		///<param name="ieee">IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</param>
		///<param name="endpointId">Endpoint id for the cluster</param>
		///<param name="clusterId">ZCL cluster to retrieve attributes for</param>
		///<param name="clusterType">type of the cluster</param>
		///<param name="command">id of the command to execute</param>
		///<param name="commandType">type of the command to execute</param>
		///<param name="args">args to pass to the command eg: [arg1, arg2, argN]</param>
		///<param name="manufacturer">manufacturer code eg: 252</param>
		public void IssueZigbeeClusterCommand(string @ieee, long @endpointId, long @clusterId, long @command, object @commandType, object? @clusterType = null, object? @args = null, string? @manufacturer = null)
		{
			_haContext.CallService("zha", "issue_zigbee_cluster_command", null, new ZhaIssueZigbeeClusterCommandParameters{Ieee = @ieee, EndpointId = @endpointId, ClusterId = @clusterId, ClusterType = @clusterType, Command = @command, CommandType = @commandType, Args = @args, Manufacturer = @manufacturer});
		}

		///<summary>Issue command on the specified cluster on the specified group.</summary>
		public void IssueZigbeeGroupCommand(ZhaIssueZigbeeGroupCommandParameters data)
		{
			_haContext.CallService("zha", "issue_zigbee_group_command", null, data);
		}

		///<summary>Issue command on the specified cluster on the specified group.</summary>
		///<param name="group">Hexadecimal address of the group eg: 546</param>
		///<param name="clusterId">ZCL cluster to send command to</param>
		///<param name="clusterType">type of the cluster</param>
		///<param name="command">id of the command to execute</param>
		///<param name="args">args to pass to the command eg: [arg1, arg2, argN]</param>
		///<param name="manufacturer">manufacturer code eg: 252</param>
		public void IssueZigbeeGroupCommand(string @group, long @clusterId, long @command, object? @clusterType = null, object? @args = null, string? @manufacturer = null)
		{
			_haContext.CallService("zha", "issue_zigbee_group_command", null, new ZhaIssueZigbeeGroupCommandParameters{Group = @group, ClusterId = @clusterId, ClusterType = @clusterType, Command = @command, Args = @args, Manufacturer = @manufacturer});
		}

		///<summary>Allow nodes to join the Zigbee network.</summary>
		public void Permit(ZhaPermitParameters data)
		{
			_haContext.CallService("zha", "permit", null, data);
		}

		///<summary>Allow nodes to join the Zigbee network.</summary>
		///<param name="duration">Time to permit joins, in seconds</param>
		///<param name="ieee">IEEE address of the node permitting new joins eg: 00:0d:6f:00:05:7d:2d:34</param>
		///<param name="sourceIeee">IEEE address of the joining device (must be used with install code) eg: 00:0a:bf:00:01:10:23:35</param>
		///<param name="installCode">Install code of the joining device (must be used with source_ieee) eg: 1234-5678-1234-5678-AABB-CCDD-AABB-CCDD-EEFF</param>
		///<param name="qrCode">value of the QR install code (different between vendors) eg: Z:000D6FFFFED4163B$I:52797BF4A5084DAA8E1712B61741CA024051</param>
		public void Permit(long? @duration = null, string? @ieee = null, string? @sourceIeee = null, string? @installCode = null, string? @qrCode = null)
		{
			_haContext.CallService("zha", "permit", null, new ZhaPermitParameters{Duration = @duration, Ieee = @ieee, SourceIeee = @sourceIeee, InstallCode = @installCode, QrCode = @qrCode});
		}

		///<summary>Remove a node from the Zigbee network.</summary>
		public void Remove(ZhaRemoveParameters data)
		{
			_haContext.CallService("zha", "remove", null, data);
		}

		///<summary>Remove a node from the Zigbee network.</summary>
		///<param name="ieee">IEEE address of the node to remove eg: 00:0d:6f:00:05:7d:2d:34</param>
		public void Remove(string @ieee)
		{
			_haContext.CallService("zha", "remove", null, new ZhaRemoveParameters{Ieee = @ieee});
		}

		///<summary>Set a user code on a lock</summary>
		///<param name="target">The target for this service call</param>
		public void SetLockUserCode(ServiceTarget target, ZhaSetLockUserCodeParameters data)
		{
			_haContext.CallService("zha", "set_lock_user_code", target, data);
		}

		///<summary>Set a user code on a lock</summary>
		///<param name="target">The target for this service call</param>
		///<param name="codeSlot">Code slot to set the code in eg: 1</param>
		///<param name="userCode">Code to set eg: 1234</param>
		public void SetLockUserCode(ServiceTarget target, string @codeSlot, string @userCode)
		{
			_haContext.CallService("zha", "set_lock_user_code", target, new ZhaSetLockUserCodeParameters{CodeSlot = @codeSlot, UserCode = @userCode});
		}

		///<summary>Set attribute value for the specified cluster on the specified entity.</summary>
		public void SetZigbeeClusterAttribute(ZhaSetZigbeeClusterAttributeParameters data)
		{
			_haContext.CallService("zha", "set_zigbee_cluster_attribute", null, data);
		}

		///<summary>Set attribute value for the specified cluster on the specified entity.</summary>
		///<param name="ieee">IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</param>
		///<param name="endpointId">Endpoint id for the cluster</param>
		///<param name="clusterId">ZCL cluster to retrieve attributes for</param>
		///<param name="clusterType">type of the cluster</param>
		///<param name="attribute">id of the attribute to set eg: 0</param>
		///<param name="value">value to write to the attribute eg: 1</param>
		///<param name="manufacturer">manufacturer code eg: 252</param>
		public void SetZigbeeClusterAttribute(string @ieee, long @endpointId, long @clusterId, long @attribute, string @value, object? @clusterType = null, string? @manufacturer = null)
		{
			_haContext.CallService("zha", "set_zigbee_cluster_attribute", null, new ZhaSetZigbeeClusterAttributeParameters{Ieee = @ieee, EndpointId = @endpointId, ClusterId = @clusterId, ClusterType = @clusterType, Attribute = @attribute, Value = @value, Manufacturer = @manufacturer});
		}

		///<summary>This service uses the WD capabilities to emit a quick audible/visible pulse called a "squawk". The squawk command has no effect if the WD is currently active (warning in progress).</summary>
		public void WarningDeviceSquawk(ZhaWarningDeviceSquawkParameters data)
		{
			_haContext.CallService("zha", "warning_device_squawk", null, data);
		}

		///<summary>This service uses the WD capabilities to emit a quick audible/visible pulse called a "squawk". The squawk command has no effect if the WD is currently active (warning in progress).</summary>
		///<param name="ieee">IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</param>
		///<param name="mode">The Squawk Mode field is used as a 4-bit enumeration, and can have one of the values shown in Table 8-24 of the ZCL spec - Squawk Mode Field. The exact operation of each mode (how the WD “squawks”) is implementation specific.</param>
		///<param name="strobe">The strobe field is used as a Boolean, and determines if the visual indication is also required in addition to the audible squawk, as shown in Table 8-25 of the ZCL spec - Strobe Bit.</param>
		///<param name="level">The squawk level field is used as a 2-bit enumeration, and determines the intensity of audible squawk sound as shown in Table 8-26 of the ZCL spec - Squawk Level Field Values.</param>
		public void WarningDeviceSquawk(string @ieee, long? @mode = null, long? @strobe = null, long? @level = null)
		{
			_haContext.CallService("zha", "warning_device_squawk", null, new ZhaWarningDeviceSquawkParameters{Ieee = @ieee, Mode = @mode, Strobe = @strobe, Level = @level});
		}

		///<summary>This service starts the WD operation. The WD alerts the surrounding area by audible (siren) and visual (strobe) signals.</summary>
		public void WarningDeviceWarn(ZhaWarningDeviceWarnParameters data)
		{
			_haContext.CallService("zha", "warning_device_warn", null, data);
		}

		///<summary>This service starts the WD operation. The WD alerts the surrounding area by audible (siren) and visual (strobe) signals.</summary>
		///<param name="ieee">IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</param>
		///<param name="mode">The Warning Mode field is used as an 4-bit enumeration, can have one of the values 0-6 defined below in table 8-20 of the ZCL spec. The exact behavior of the WD device in each mode is according to the relevant security standards.</param>
		///<param name="strobe">The Strobe field is used as a 2-bit enumeration, and determines if the visual indication is required in addition to the audible siren, as indicated in Table 8-21 of the ZCL spec. "0" means no strobe, "1" means strobe. If the strobe field is “1” and the Warning Mode is “0” (“Stop”) then only the strobe is activated.</param>
		///<param name="level">The Siren Level field is used as a 2-bit enumeration, and indicates the intensity of audible squawk sound as shown in Table 8-22 of the ZCL spec.</param>
		///<param name="duration">Requested duration of warning, in seconds (16 bit). If both Strobe and Warning Mode are "0" this field SHALL be ignored.</param>
		///<param name="dutyCycle">Indicates the length of the flash cycle. This provides a means of varying the flash duration for different alarm types (e.g., fire, police, burglar). Valid range is 0-100 in increments of 10. All other values SHALL be rounded to the nearest valid value. Strobe SHALL calculate duty cycle over a duration of one second. The ON state SHALL precede the OFF state. For example, if Strobe Duty Cycle Field specifies “40,” then the strobe SHALL flash ON for 4/10ths of a second and then turn OFF for 6/10ths of a second.</param>
		///<param name="intensity">Indicates the intensity of the strobe as shown in Table 8-23 of the ZCL spec. This attribute is designed to vary the output of the strobe (i.e., brightness) and not its frequency, which is detailed in section 8.4.2.3.1.6 of the ZCL spec.</param>
		public void WarningDeviceWarn(string @ieee, long? @mode = null, long? @strobe = null, long? @level = null, long? @duration = null, long? @dutyCycle = null, long? @intensity = null)
		{
			_haContext.CallService("zha", "warning_device_warn", null, new ZhaWarningDeviceWarnParameters{Ieee = @ieee, Mode = @mode, Strobe = @strobe, Level = @level, Duration = @duration, DutyCycle = @dutyCycle, Intensity = @intensity});
		}
	}

	public record ZhaClearLockUserCodeParameters
	{
		///<summary>Code slot to clear code from eg: 1</summary>
		[JsonPropertyName("code_slot")]
		public string? CodeSlot { get; init; }
	}

	public record ZhaDisableLockUserCodeParameters
	{
		///<summary>Code slot to disable eg: 1</summary>
		[JsonPropertyName("code_slot")]
		public string? CodeSlot { get; init; }
	}

	public record ZhaEnableLockUserCodeParameters
	{
		///<summary>Code slot to enable eg: 1</summary>
		[JsonPropertyName("code_slot")]
		public string? CodeSlot { get; init; }
	}

	public record ZhaIssueZigbeeClusterCommandParameters
	{
		///<summary>IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</summary>
		[JsonPropertyName("ieee")]
		public string? Ieee { get; init; }

		///<summary>Endpoint id for the cluster</summary>
		[JsonPropertyName("endpoint_id")]
		public long? EndpointId { get; init; }

		///<summary>ZCL cluster to retrieve attributes for</summary>
		[JsonPropertyName("cluster_id")]
		public long? ClusterId { get; init; }

		///<summary>type of the cluster</summary>
		[JsonPropertyName("cluster_type")]
		public object? ClusterType { get; init; }

		///<summary>id of the command to execute</summary>
		[JsonPropertyName("command")]
		public long? Command { get; init; }

		///<summary>type of the command to execute</summary>
		[JsonPropertyName("command_type")]
		public object? CommandType { get; init; }

		///<summary>args to pass to the command eg: [arg1, arg2, argN]</summary>
		[JsonPropertyName("args")]
		public object? Args { get; init; }

		///<summary>manufacturer code eg: 252</summary>
		[JsonPropertyName("manufacturer")]
		public string? Manufacturer { get; init; }
	}

	public record ZhaIssueZigbeeGroupCommandParameters
	{
		///<summary>Hexadecimal address of the group eg: 546</summary>
		[JsonPropertyName("group")]
		public string? Group { get; init; }

		///<summary>ZCL cluster to send command to</summary>
		[JsonPropertyName("cluster_id")]
		public long? ClusterId { get; init; }

		///<summary>type of the cluster</summary>
		[JsonPropertyName("cluster_type")]
		public object? ClusterType { get; init; }

		///<summary>id of the command to execute</summary>
		[JsonPropertyName("command")]
		public long? Command { get; init; }

		///<summary>args to pass to the command eg: [arg1, arg2, argN]</summary>
		[JsonPropertyName("args")]
		public object? Args { get; init; }

		///<summary>manufacturer code eg: 252</summary>
		[JsonPropertyName("manufacturer")]
		public string? Manufacturer { get; init; }
	}

	public record ZhaPermitParameters
	{
		///<summary>Time to permit joins, in seconds</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }

		///<summary>IEEE address of the node permitting new joins eg: 00:0d:6f:00:05:7d:2d:34</summary>
		[JsonPropertyName("ieee")]
		public string? Ieee { get; init; }

		///<summary>IEEE address of the joining device (must be used with install code) eg: 00:0a:bf:00:01:10:23:35</summary>
		[JsonPropertyName("source_ieee")]
		public string? SourceIeee { get; init; }

		///<summary>Install code of the joining device (must be used with source_ieee) eg: 1234-5678-1234-5678-AABB-CCDD-AABB-CCDD-EEFF</summary>
		[JsonPropertyName("install_code")]
		public string? InstallCode { get; init; }

		///<summary>value of the QR install code (different between vendors) eg: Z:000D6FFFFED4163B$I:52797BF4A5084DAA8E1712B61741CA024051</summary>
		[JsonPropertyName("qr_code")]
		public string? QrCode { get; init; }
	}

	public record ZhaRemoveParameters
	{
		///<summary>IEEE address of the node to remove eg: 00:0d:6f:00:05:7d:2d:34</summary>
		[JsonPropertyName("ieee")]
		public string? Ieee { get; init; }
	}

	public record ZhaSetLockUserCodeParameters
	{
		///<summary>Code slot to set the code in eg: 1</summary>
		[JsonPropertyName("code_slot")]
		public string? CodeSlot { get; init; }

		///<summary>Code to set eg: 1234</summary>
		[JsonPropertyName("user_code")]
		public string? UserCode { get; init; }
	}

	public record ZhaSetZigbeeClusterAttributeParameters
	{
		///<summary>IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</summary>
		[JsonPropertyName("ieee")]
		public string? Ieee { get; init; }

		///<summary>Endpoint id for the cluster</summary>
		[JsonPropertyName("endpoint_id")]
		public long? EndpointId { get; init; }

		///<summary>ZCL cluster to retrieve attributes for</summary>
		[JsonPropertyName("cluster_id")]
		public long? ClusterId { get; init; }

		///<summary>type of the cluster</summary>
		[JsonPropertyName("cluster_type")]
		public object? ClusterType { get; init; }

		///<summary>id of the attribute to set eg: 0</summary>
		[JsonPropertyName("attribute")]
		public long? Attribute { get; init; }

		///<summary>value to write to the attribute eg: 1</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }

		///<summary>manufacturer code eg: 252</summary>
		[JsonPropertyName("manufacturer")]
		public string? Manufacturer { get; init; }
	}

	public record ZhaWarningDeviceSquawkParameters
	{
		///<summary>IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</summary>
		[JsonPropertyName("ieee")]
		public string? Ieee { get; init; }

		///<summary>The Squawk Mode field is used as a 4-bit enumeration, and can have one of the values shown in Table 8-24 of the ZCL spec - Squawk Mode Field. The exact operation of each mode (how the WD “squawks”) is implementation specific.</summary>
		[JsonPropertyName("mode")]
		public long? Mode { get; init; }

		///<summary>The strobe field is used as a Boolean, and determines if the visual indication is also required in addition to the audible squawk, as shown in Table 8-25 of the ZCL spec - Strobe Bit.</summary>
		[JsonPropertyName("strobe")]
		public long? Strobe { get; init; }

		///<summary>The squawk level field is used as a 2-bit enumeration, and determines the intensity of audible squawk sound as shown in Table 8-26 of the ZCL spec - Squawk Level Field Values.</summary>
		[JsonPropertyName("level")]
		public long? Level { get; init; }
	}

	public record ZhaWarningDeviceWarnParameters
	{
		///<summary>IEEE address for the device eg: 00:0d:6f:00:05:7d:2d:34</summary>
		[JsonPropertyName("ieee")]
		public string? Ieee { get; init; }

		///<summary>The Warning Mode field is used as an 4-bit enumeration, can have one of the values 0-6 defined below in table 8-20 of the ZCL spec. The exact behavior of the WD device in each mode is according to the relevant security standards.</summary>
		[JsonPropertyName("mode")]
		public long? Mode { get; init; }

		///<summary>The Strobe field is used as a 2-bit enumeration, and determines if the visual indication is required in addition to the audible siren, as indicated in Table 8-21 of the ZCL spec. "0" means no strobe, "1" means strobe. If the strobe field is “1” and the Warning Mode is “0” (“Stop”) then only the strobe is activated.</summary>
		[JsonPropertyName("strobe")]
		public long? Strobe { get; init; }

		///<summary>The Siren Level field is used as a 2-bit enumeration, and indicates the intensity of audible squawk sound as shown in Table 8-22 of the ZCL spec.</summary>
		[JsonPropertyName("level")]
		public long? Level { get; init; }

		///<summary>Requested duration of warning, in seconds (16 bit). If both Strobe and Warning Mode are "0" this field SHALL be ignored.</summary>
		[JsonPropertyName("duration")]
		public long? Duration { get; init; }

		///<summary>Indicates the length of the flash cycle. This provides a means of varying the flash duration for different alarm types (e.g., fire, police, burglar). Valid range is 0-100 in increments of 10. All other values SHALL be rounded to the nearest valid value. Strobe SHALL calculate duty cycle over a duration of one second. The ON state SHALL precede the OFF state. For example, if Strobe Duty Cycle Field specifies “40,” then the strobe SHALL flash ON for 4/10ths of a second and then turn OFF for 6/10ths of a second.</summary>
		[JsonPropertyName("duty_cycle")]
		public long? DutyCycle { get; init; }

		///<summary>Indicates the intensity of the strobe as shown in Table 8-23 of the ZCL spec. This attribute is designed to vary the output of the strobe (i.e., brightness) and not its frequency, which is detailed in section 8.4.2.3.1.6 of the ZCL spec.</summary>
		[JsonPropertyName("intensity")]
		public long? Intensity { get; init; }
	}

	public class ZoneServices
	{
		private readonly IHaContext _haContext;
		public ZoneServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Reload the YAML-based zone configuration.</summary>
		public void Reload()
		{
			_haContext.CallService("zone", "reload", null);
		}
	}

	public class ZwaveJsServices
	{
		private readonly IHaContext _haContext;
		public ZwaveJsServices(IHaContext haContext)
		{
			_haContext = haContext;
		}

		///<summary>Allow for bulk setting partial parameters. Useful when multiple partial parameters have to be set at the same time.</summary>
		///<param name="target">The target for this service call</param>
		public void BulkSetPartialConfigParameters(ServiceTarget target, ZwaveJsBulkSetPartialConfigParametersParameters data)
		{
			_haContext.CallService("zwave_js", "bulk_set_partial_config_parameters", target, data);
		}

		///<summary>Allow for bulk setting partial parameters. Useful when multiple partial parameters have to be set at the same time.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="parameter">The id of the configuration parameter you want to configure. eg: 9</param>
		///<param name="value">The new value(s) to set for this configuration parameter. Can either be a raw integer value to represent the bulk change or a mapping where the key is the bitmask (either in hex or integer form) and the value is the new value you want to set for that partial parameter. eg: {"0x1":1,"0x10":1,"0x20":1,"0x40":1}</param>
		public void BulkSetPartialConfigParameters(ServiceTarget target, string @parameter, object @value)
		{
			_haContext.CallService("zwave_js", "bulk_set_partial_config_parameters", target, new ZwaveJsBulkSetPartialConfigParametersParameters{Parameter = @parameter, Value = @value});
		}

		///<summary>Allows for calling a Command Class API on a node. Some Command Classes can't be fully controlled via the `set_value` service and require direct calls to the Command Class API.</summary>
		///<param name="target">The target for this service call</param>
		public void InvokeCcApi(ServiceTarget target, ZwaveJsInvokeCcApiParameters data)
		{
			_haContext.CallService("zwave_js", "invoke_cc_api", target, data);
		}

		///<summary>Allows for calling a Command Class API on a node. Some Command Classes can't be fully controlled via the `set_value` service and require direct calls to the Command Class API.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="commandClass">The ID of the command class that you want to issue a command to. eg: 132</param>
		///<param name="endpoint">The endpoint to call the API on. If an endpoint is specified, that endpoint will be targeted for all nodes associated with the target areas, devices, and/or entities. If an endpoint is not specified, the root endpoint (0) will be targeted for nodes associated with target areas and devices, and the endpoint for the primary value of each entity will be targeted. eg: 1</param>
		///<param name="methodName">The name of the API method to call. Refer to the Z-Wave JS Command Class API documentation (https://zwave-js.github.io/node-zwave-js/#/api/CCs/index) for available methods. eg: setInterval</param>
		///<param name="parameters">A list of parameters to pass to the API method. Refer to the Z-Wave JS Command Class API documentation (https://zwave-js.github.io/node-zwave-js/#/api/CCs/index) for parameters. eg: [1,1]</param>
		public void InvokeCcApi(ServiceTarget target, string @commandClass, string @methodName, object @parameters, string? @endpoint = null)
		{
			_haContext.CallService("zwave_js", "invoke_cc_api", target, new ZwaveJsInvokeCcApiParameters{CommandClass = @commandClass, Endpoint = @endpoint, MethodName = @methodName, Parameters = @parameters});
		}

		///<summary>Allow for changing any value that Z-Wave JS recognizes on multiple Z-Wave devices using multicast, so all devices receive the message simultaneously. This service has minimal validation so only use this service if you know what you are doing.</summary>
		///<param name="target">The target for this service call</param>
		public void MulticastSetValue(ServiceTarget target, ZwaveJsMulticastSetValueParameters data)
		{
			_haContext.CallService("zwave_js", "multicast_set_value", target, data);
		}

		///<summary>Allow for changing any value that Z-Wave JS recognizes on multiple Z-Wave devices using multicast, so all devices receive the message simultaneously. This service has minimal validation so only use this service if you know what you are doing.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="broadcast">Whether command should be broadcast to all devices on the network. eg: True</param>
		///<param name="commandClass">The ID of the command class for the value. eg: 117</param>
		///<param name="endpoint">The endpoint for the value. eg: 1</param>
		///<param name="property">The ID of the property for the value. eg: currentValue</param>
		///<param name="propertyKey">The ID of the property key for the value eg: 1</param>
		///<param name="options">Set value options map. Refer to the Z-Wave JS documentation for more information on what options can be set.</param>
		///<param name="value">The new value to set. eg: ffbb99</param>
		public void MulticastSetValue(ServiceTarget target, string @commandClass, string @property, object @value, bool? @broadcast = null, string? @endpoint = null, string? @propertyKey = null, object? @options = null)
		{
			_haContext.CallService("zwave_js", "multicast_set_value", target, new ZwaveJsMulticastSetValueParameters{Broadcast = @broadcast, CommandClass = @commandClass, Endpoint = @endpoint, Property = @property, PropertyKey = @propertyKey, Options = @options, Value = @value});
		}

		///<summary>Forces Z-Wave JS to try to reach a node. This can be used to update the status of the node in Z-Wave JS when you think it doesn't accurately reflect reality, e.g. reviving a failed/dead node or marking the node as asleep.</summary>
		///<param name="target">The target for this service call</param>
		public void Ping(ServiceTarget target)
		{
			_haContext.CallService("zwave_js", "ping", target);
		}

		///<summary>Force update value(s) for a Z-Wave entity</summary>
		public void RefreshValue(ZwaveJsRefreshValueParameters data)
		{
			_haContext.CallService("zwave_js", "refresh_value", null, data);
		}

		///<summary>Force update value(s) for a Z-Wave entity</summary>
		///<param name="entityId">Entity whose value(s) should be refreshed eg: sensor.family_room_motion</param>
		///<param name="refreshAllValues">Whether to refresh all values (true) or just the primary value (false)</param>
		public void RefreshValue(string @entityId, bool? @refreshAllValues = null)
		{
			_haContext.CallService("zwave_js", "refresh_value", null, new ZwaveJsRefreshValueParameters{EntityId = @entityId, RefreshAllValues = @refreshAllValues});
		}

		///<summary>Resets the meter(s) on a node.</summary>
		///<param name="target">The target for this service call</param>
		public void ResetMeter(ServiceTarget target, ZwaveJsResetMeterParameters data)
		{
			_haContext.CallService("zwave_js", "reset_meter", target, data);
		}

		///<summary>Resets the meter(s) on a node.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="meterType">The type of meter to reset. Not all meters support the ability to pick a meter type to reset. eg: 1</param>
		///<param name="value">The value that meter(s) should be reset to. Not all meters support the ability to be reset to a specific value. eg: 5</param>
		public void ResetMeter(ServiceTarget target, string? @meterType = null, string? @value = null)
		{
			_haContext.CallService("zwave_js", "reset_meter", target, new ZwaveJsResetMeterParameters{MeterType = @meterType, Value = @value});
		}

		///<summary>Allow for changing configuration parameters of your Z-Wave devices.</summary>
		///<param name="target">The target for this service call</param>
		public void SetConfigParameter(ServiceTarget target, ZwaveJsSetConfigParameterParameters data)
		{
			_haContext.CallService("zwave_js", "set_config_parameter", target, data);
		}

		///<summary>Allow for changing configuration parameters of your Z-Wave devices.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="parameter">The (name or id of the) configuration parameter you want to configure. eg: Minimum brightness level</param>
		///<param name="value">The new value to set for this configuration parameter. eg: 5</param>
		///<param name="bitmask">Target a specific bitmask (see the documentation for more information).</param>
		public void SetConfigParameter(ServiceTarget target, string @parameter, string @value, string? @bitmask = null)
		{
			_haContext.CallService("zwave_js", "set_config_parameter", target, new ZwaveJsSetConfigParameterParameters{Parameter = @parameter, Value = @value, Bitmask = @bitmask});
		}

		///<summary>Allow for changing any value that Z-Wave JS recognizes on a Z-Wave device. This service has minimal validation so only use this service if you know what you are doing.</summary>
		///<param name="target">The target for this service call</param>
		public void SetValue(ServiceTarget target, ZwaveJsSetValueParameters data)
		{
			_haContext.CallService("zwave_js", "set_value", target, data);
		}

		///<summary>Allow for changing any value that Z-Wave JS recognizes on a Z-Wave device. This service has minimal validation so only use this service if you know what you are doing.</summary>
		///<param name="target">The target for this service call</param>
		///<param name="commandClass">The ID of the command class for the value. eg: 117</param>
		///<param name="endpoint">The endpoint for the value. eg: 1</param>
		///<param name="property">The ID of the property for the value. eg: currentValue</param>
		///<param name="propertyKey">The ID of the property key for the value eg: 1</param>
		///<param name="value">The new value to set. eg: ffbb99</param>
		///<param name="options">Set value options map. Refer to the Z-Wave JS documentation for more information on what options can be set.</param>
		///<param name="waitForResult">Whether or not to wait for a response from the node. If not included in the payload, the integration will decide whether to wait or not. If set to `true`, note that the service call can take a while if setting a value on an asleep battery device.</param>
		public void SetValue(ServiceTarget target, string @commandClass, string @property, object @value, string? @endpoint = null, string? @propertyKey = null, object? @options = null, bool? @waitForResult = null)
		{
			_haContext.CallService("zwave_js", "set_value", target, new ZwaveJsSetValueParameters{CommandClass = @commandClass, Endpoint = @endpoint, Property = @property, PropertyKey = @propertyKey, Value = @value, Options = @options, WaitForResult = @waitForResult});
		}
	}

	public record ZwaveJsBulkSetPartialConfigParametersParameters
	{
		///<summary>The id of the configuration parameter you want to configure. eg: 9</summary>
		[JsonPropertyName("parameter")]
		public string? Parameter { get; init; }

		///<summary>The new value(s) to set for this configuration parameter. Can either be a raw integer value to represent the bulk change or a mapping where the key is the bitmask (either in hex or integer form) and the value is the new value you want to set for that partial parameter. eg: {"0x1":1,"0x10":1,"0x20":1,"0x40":1}</summary>
		[JsonPropertyName("value")]
		public object? Value { get; init; }
	}

	public record ZwaveJsInvokeCcApiParameters
	{
		///<summary>The ID of the command class that you want to issue a command to. eg: 132</summary>
		[JsonPropertyName("command_class")]
		public string? CommandClass { get; init; }

		///<summary>The endpoint to call the API on. If an endpoint is specified, that endpoint will be targeted for all nodes associated with the target areas, devices, and/or entities. If an endpoint is not specified, the root endpoint (0) will be targeted for nodes associated with target areas and devices, and the endpoint for the primary value of each entity will be targeted. eg: 1</summary>
		[JsonPropertyName("endpoint")]
		public string? Endpoint { get; init; }

		///<summary>The name of the API method to call. Refer to the Z-Wave JS Command Class API documentation (https://zwave-js.github.io/node-zwave-js/#/api/CCs/index) for available methods. eg: setInterval</summary>
		[JsonPropertyName("method_name")]
		public string? MethodName { get; init; }

		///<summary>A list of parameters to pass to the API method. Refer to the Z-Wave JS Command Class API documentation (https://zwave-js.github.io/node-zwave-js/#/api/CCs/index) for parameters. eg: [1,1]</summary>
		[JsonPropertyName("parameters")]
		public object? Parameters { get; init; }
	}

	public record ZwaveJsMulticastSetValueParameters
	{
		///<summary>Whether command should be broadcast to all devices on the network. eg: True</summary>
		[JsonPropertyName("broadcast")]
		public bool? Broadcast { get; init; }

		///<summary>The ID of the command class for the value. eg: 117</summary>
		[JsonPropertyName("command_class")]
		public string? CommandClass { get; init; }

		///<summary>The endpoint for the value. eg: 1</summary>
		[JsonPropertyName("endpoint")]
		public string? Endpoint { get; init; }

		///<summary>The ID of the property for the value. eg: currentValue</summary>
		[JsonPropertyName("property")]
		public string? Property { get; init; }

		///<summary>The ID of the property key for the value eg: 1</summary>
		[JsonPropertyName("property_key")]
		public string? PropertyKey { get; init; }

		///<summary>Set value options map. Refer to the Z-Wave JS documentation for more information on what options can be set.</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }

		///<summary>The new value to set. eg: ffbb99</summary>
		[JsonPropertyName("value")]
		public object? Value { get; init; }
	}

	public record ZwaveJsRefreshValueParameters
	{
		///<summary>Entity whose value(s) should be refreshed eg: sensor.family_room_motion</summary>
		[JsonPropertyName("entity_id")]
		public string? EntityId { get; init; }

		///<summary>Whether to refresh all values (true) or just the primary value (false)</summary>
		[JsonPropertyName("refresh_all_values")]
		public bool? RefreshAllValues { get; init; }
	}

	public record ZwaveJsResetMeterParameters
	{
		///<summary>The type of meter to reset. Not all meters support the ability to pick a meter type to reset. eg: 1</summary>
		[JsonPropertyName("meter_type")]
		public string? MeterType { get; init; }

		///<summary>The value that meter(s) should be reset to. Not all meters support the ability to be reset to a specific value. eg: 5</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }
	}

	public record ZwaveJsSetConfigParameterParameters
	{
		///<summary>The (name or id of the) configuration parameter you want to configure. eg: Minimum brightness level</summary>
		[JsonPropertyName("parameter")]
		public string? Parameter { get; init; }

		///<summary>The new value to set for this configuration parameter. eg: 5</summary>
		[JsonPropertyName("value")]
		public string? Value { get; init; }

		///<summary>Target a specific bitmask (see the documentation for more information).</summary>
		[JsonPropertyName("bitmask")]
		public string? Bitmask { get; init; }
	}

	public record ZwaveJsSetValueParameters
	{
		///<summary>The ID of the command class for the value. eg: 117</summary>
		[JsonPropertyName("command_class")]
		public string? CommandClass { get; init; }

		///<summary>The endpoint for the value. eg: 1</summary>
		[JsonPropertyName("endpoint")]
		public string? Endpoint { get; init; }

		///<summary>The ID of the property for the value. eg: currentValue</summary>
		[JsonPropertyName("property")]
		public string? Property { get; init; }

		///<summary>The ID of the property key for the value eg: 1</summary>
		[JsonPropertyName("property_key")]
		public string? PropertyKey { get; init; }

		///<summary>The new value to set. eg: ffbb99</summary>
		[JsonPropertyName("value")]
		public object? Value { get; init; }

		///<summary>Set value options map. Refer to the Z-Wave JS documentation for more information on what options can be set.</summary>
		[JsonPropertyName("options")]
		public object? Options { get; init; }

		///<summary>Whether or not to wait for a response from the node. If not included in the payload, the integration will decide whether to wait or not. If set to `true`, note that the service call can take a while if setting a value on an asleep battery device.</summary>
		[JsonPropertyName("wait_for_result")]
		public bool? WaitForResult { get; init; }
	}

	public static class AutomationEntityExtensionMethods
	{
		///<summary>Toggle (enable / disable) an automation.</summary>
		public static void Toggle(this AutomationEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle (enable / disable) an automation.</summary>
		public static void Toggle(this IEnumerable<AutomationEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Trigger the actions of an automation.</summary>
		public static void Trigger(this AutomationEntity target, AutomationTriggerParameters data)
		{
			target.CallService("trigger", data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		public static void Trigger(this IEnumerable<AutomationEntity> target, AutomationTriggerParameters data)
		{
			target.CallService("trigger", data);
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The AutomationEntity to call this service for</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public static void Trigger(this AutomationEntity target, bool? @skipCondition = null)
		{
			target.CallService("trigger", new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Trigger the actions of an automation.</summary>
		///<param name="target">The IEnumerable<AutomationEntity> to call this service for</param>
		///<param name="skipCondition">Whether or not the conditions will be skipped.</param>
		public static void Trigger(this IEnumerable<AutomationEntity> target, bool? @skipCondition = null)
		{
			target.CallService("trigger", new AutomationTriggerParameters{SkipCondition = @skipCondition});
		}

		///<summary>Disable an automation.</summary>
		public static void TurnOff(this AutomationEntity target, AutomationTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Disable an automation.</summary>
		public static void TurnOff(this IEnumerable<AutomationEntity> target, AutomationTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The AutomationEntity to call this service for</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public static void TurnOff(this AutomationEntity target, bool? @stopActions = null)
		{
			target.CallService("turn_off", new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Disable an automation.</summary>
		///<param name="target">The IEnumerable<AutomationEntity> to call this service for</param>
		///<param name="stopActions">Stop currently running actions.</param>
		public static void TurnOff(this IEnumerable<AutomationEntity> target, bool? @stopActions = null)
		{
			target.CallService("turn_off", new AutomationTurnOffParameters{StopActions = @stopActions});
		}

		///<summary>Enable an automation.</summary>
		public static void TurnOn(this AutomationEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Enable an automation.</summary>
		public static void TurnOn(this IEnumerable<AutomationEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class ButtonEntityExtensionMethods
	{
		///<summary>Press the button entity.</summary>
		public static void Press(this ButtonEntity target)
		{
			target.CallService("press");
		}

		///<summary>Press the button entity.</summary>
		public static void Press(this IEnumerable<ButtonEntity> target)
		{
			target.CallService("press");
		}
	}

	public static class CameraEntityExtensionMethods
	{
		///<summary>Disable the motion detection in a camera.</summary>
		public static void DisableMotionDetection(this CameraEntity target)
		{
			target.CallService("disable_motion_detection");
		}

		///<summary>Disable the motion detection in a camera.</summary>
		public static void DisableMotionDetection(this IEnumerable<CameraEntity> target)
		{
			target.CallService("disable_motion_detection");
		}

		///<summary>Enable the motion detection in a camera.</summary>
		public static void EnableMotionDetection(this CameraEntity target)
		{
			target.CallService("enable_motion_detection");
		}

		///<summary>Enable the motion detection in a camera.</summary>
		public static void EnableMotionDetection(this IEnumerable<CameraEntity> target)
		{
			target.CallService("enable_motion_detection");
		}

		///<summary>Play camera stream on supported media player.</summary>
		public static void PlayStream(this CameraEntity target, CameraPlayStreamParameters data)
		{
			target.CallService("play_stream", data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		public static void PlayStream(this IEnumerable<CameraEntity> target, CameraPlayStreamParameters data)
		{
			target.CallService("play_stream", data);
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public static void PlayStream(this CameraEntity target, string @mediaPlayer, object? @format = null)
		{
			target.CallService("play_stream", new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Play camera stream on supported media player.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="mediaPlayer">Name(s) of media player to stream to.</param>
		///<param name="format">Stream format supported by media player.</param>
		public static void PlayStream(this IEnumerable<CameraEntity> target, string @mediaPlayer, object? @format = null)
		{
			target.CallService("play_stream", new CameraPlayStreamParameters{MediaPlayer = @mediaPlayer, Format = @format});
		}

		///<summary>Record live camera feed.</summary>
		public static void Record(this CameraEntity target, CameraRecordParameters data)
		{
			target.CallService("record", data);
		}

		///<summary>Record live camera feed.</summary>
		public static void Record(this IEnumerable<CameraEntity> target, CameraRecordParameters data)
		{
			target.CallService("record", data);
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public static void Record(this CameraEntity target, string @filename, long? @duration = null, long? @lookback = null)
		{
			target.CallService("record", new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Record live camera feed.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. Must be mp4. eg: /tmp/snapshot_{{ entity_id.name }}.mp4</param>
		///<param name="duration">Target recording length.</param>
		///<param name="lookback">Target lookback period to include in addition to duration. Only available if there is currently an active HLS stream.</param>
		public static void Record(this IEnumerable<CameraEntity> target, string @filename, long? @duration = null, long? @lookback = null)
		{
			target.CallService("record", new CameraRecordParameters{Filename = @filename, Duration = @duration, Lookback = @lookback});
		}

		///<summary>Take a snapshot from a camera.</summary>
		public static void Snapshot(this CameraEntity target, CameraSnapshotParameters data)
		{
			target.CallService("snapshot", data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		public static void Snapshot(this IEnumerable<CameraEntity> target, CameraSnapshotParameters data)
		{
			target.CallService("snapshot", data);
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The CameraEntity to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public static void Snapshot(this CameraEntity target, string @filename)
		{
			target.CallService("snapshot", new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Take a snapshot from a camera.</summary>
		///<param name="target">The IEnumerable<CameraEntity> to call this service for</param>
		///<param name="filename">Template of a Filename. Variable is entity_id. eg: /tmp/snapshot_{{ entity_id.name }}.jpg</param>
		public static void Snapshot(this IEnumerable<CameraEntity> target, string @filename)
		{
			target.CallService("snapshot", new CameraSnapshotParameters{Filename = @filename});
		}

		///<summary>Turn off camera.</summary>
		public static void TurnOff(this CameraEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn off camera.</summary>
		public static void TurnOff(this IEnumerable<CameraEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn on camera.</summary>
		public static void TurnOn(this CameraEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn on camera.</summary>
		public static void TurnOn(this IEnumerable<CameraEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class CoverEntityExtensionMethods
	{
		///<summary>Close all or specified cover.</summary>
		public static void CloseCover(this CoverEntity target)
		{
			target.CallService("close_cover");
		}

		///<summary>Close all or specified cover.</summary>
		public static void CloseCover(this IEnumerable<CoverEntity> target)
		{
			target.CallService("close_cover");
		}

		///<summary>Close all or specified cover tilt.</summary>
		public static void CloseCoverTilt(this CoverEntity target)
		{
			target.CallService("close_cover_tilt");
		}

		///<summary>Close all or specified cover tilt.</summary>
		public static void CloseCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("close_cover_tilt");
		}

		///<summary>Open all or specified cover.</summary>
		public static void OpenCover(this CoverEntity target)
		{
			target.CallService("open_cover");
		}

		///<summary>Open all or specified cover.</summary>
		public static void OpenCover(this IEnumerable<CoverEntity> target)
		{
			target.CallService("open_cover");
		}

		///<summary>Open all or specified cover tilt.</summary>
		public static void OpenCoverTilt(this CoverEntity target)
		{
			target.CallService("open_cover_tilt");
		}

		///<summary>Open all or specified cover tilt.</summary>
		public static void OpenCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("open_cover_tilt");
		}

		///<summary>Move to specific position all or specified cover.</summary>
		public static void SetCoverPosition(this CoverEntity target, CoverSetCoverPositionParameters data)
		{
			target.CallService("set_cover_position", data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		public static void SetCoverPosition(this IEnumerable<CoverEntity> target, CoverSetCoverPositionParameters data)
		{
			target.CallService("set_cover_position", data);
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The CoverEntity to call this service for</param>
		///<param name="position">Position of the cover</param>
		public static void SetCoverPosition(this CoverEntity target, long @position)
		{
			target.CallService("set_cover_position", new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover.</summary>
		///<param name="target">The IEnumerable<CoverEntity> to call this service for</param>
		///<param name="position">Position of the cover</param>
		public static void SetCoverPosition(this IEnumerable<CoverEntity> target, long @position)
		{
			target.CallService("set_cover_position", new CoverSetCoverPositionParameters{Position = @position});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		public static void SetCoverTiltPosition(this CoverEntity target, CoverSetCoverTiltPositionParameters data)
		{
			target.CallService("set_cover_tilt_position", data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		public static void SetCoverTiltPosition(this IEnumerable<CoverEntity> target, CoverSetCoverTiltPositionParameters data)
		{
			target.CallService("set_cover_tilt_position", data);
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The CoverEntity to call this service for</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public static void SetCoverTiltPosition(this CoverEntity target, long @tiltPosition)
		{
			target.CallService("set_cover_tilt_position", new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Move to specific position all or specified cover tilt.</summary>
		///<param name="target">The IEnumerable<CoverEntity> to call this service for</param>
		///<param name="tiltPosition">Tilt position of the cover.</param>
		public static void SetCoverTiltPosition(this IEnumerable<CoverEntity> target, long @tiltPosition)
		{
			target.CallService("set_cover_tilt_position", new CoverSetCoverTiltPositionParameters{TiltPosition = @tiltPosition});
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCover(this CoverEntity target)
		{
			target.CallService("stop_cover");
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCover(this IEnumerable<CoverEntity> target)
		{
			target.CallService("stop_cover");
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCoverTilt(this CoverEntity target)
		{
			target.CallService("stop_cover_tilt");
		}

		///<summary>Stop all or specified cover.</summary>
		public static void StopCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("stop_cover_tilt");
		}

		///<summary>Toggle a cover open/closed.</summary>
		public static void Toggle(this CoverEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle a cover open/closed.</summary>
		public static void Toggle(this IEnumerable<CoverEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		public static void ToggleCoverTilt(this CoverEntity target)
		{
			target.CallService("toggle_cover_tilt");
		}

		///<summary>Toggle a cover tilt open/closed.</summary>
		public static void ToggleCoverTilt(this IEnumerable<CoverEntity> target)
		{
			target.CallService("toggle_cover_tilt");
		}
	}

	public static class FanEntityExtensionMethods
	{
		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		public static void DecreaseSpeed(this FanEntity target, FanDecreaseSpeedParameters data)
		{
			target.CallService("decrease_speed", data);
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		public static void DecreaseSpeed(this IEnumerable<FanEntity> target, FanDecreaseSpeedParameters data)
		{
			target.CallService("decrease_speed", data);
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The FanEntity to call this service for</param>
		///<param name="percentageStep">Decrease speed by a percentage.</param>
		public static void DecreaseSpeed(this FanEntity target, long? @percentageStep = null)
		{
			target.CallService("decrease_speed", new FanDecreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Decrease the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The IEnumerable<FanEntity> to call this service for</param>
		///<param name="percentageStep">Decrease speed by a percentage.</param>
		public static void DecreaseSpeed(this IEnumerable<FanEntity> target, long? @percentageStep = null)
		{
			target.CallService("decrease_speed", new FanDecreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		public static void IncreaseSpeed(this FanEntity target, FanIncreaseSpeedParameters data)
		{
			target.CallService("increase_speed", data);
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		public static void IncreaseSpeed(this IEnumerable<FanEntity> target, FanIncreaseSpeedParameters data)
		{
			target.CallService("increase_speed", data);
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The FanEntity to call this service for</param>
		///<param name="percentageStep">Increase speed by a percentage.</param>
		public static void IncreaseSpeed(this FanEntity target, long? @percentageStep = null)
		{
			target.CallService("increase_speed", new FanIncreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Increase the speed of the fan by one speed or a percentage_step.</summary>
		///<param name="target">The IEnumerable<FanEntity> to call this service for</param>
		///<param name="percentageStep">Increase speed by a percentage.</param>
		public static void IncreaseSpeed(this IEnumerable<FanEntity> target, long? @percentageStep = null)
		{
			target.CallService("increase_speed", new FanIncreaseSpeedParameters{PercentageStep = @percentageStep});
		}

		///<summary>Oscillate the fan.</summary>
		public static void Oscillate(this FanEntity target, FanOscillateParameters data)
		{
			target.CallService("oscillate", data);
		}

		///<summary>Oscillate the fan.</summary>
		public static void Oscillate(this IEnumerable<FanEntity> target, FanOscillateParameters data)
		{
			target.CallService("oscillate", data);
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The FanEntity to call this service for</param>
		///<param name="oscillating">Flag to turn on/off oscillation.</param>
		public static void Oscillate(this FanEntity target, bool @oscillating)
		{
			target.CallService("oscillate", new FanOscillateParameters{Oscillating = @oscillating});
		}

		///<summary>Oscillate the fan.</summary>
		///<param name="target">The IEnumerable<FanEntity> to call this service for</param>
		///<param name="oscillating">Flag to turn on/off oscillation.</param>
		public static void Oscillate(this IEnumerable<FanEntity> target, bool @oscillating)
		{
			target.CallService("oscillate", new FanOscillateParameters{Oscillating = @oscillating});
		}

		///<summary>Set the fan rotation.</summary>
		public static void SetDirection(this FanEntity target, FanSetDirectionParameters data)
		{
			target.CallService("set_direction", data);
		}

		///<summary>Set the fan rotation.</summary>
		public static void SetDirection(this IEnumerable<FanEntity> target, FanSetDirectionParameters data)
		{
			target.CallService("set_direction", data);
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The FanEntity to call this service for</param>
		///<param name="direction">The direction to rotate.</param>
		public static void SetDirection(this FanEntity target, object @direction)
		{
			target.CallService("set_direction", new FanSetDirectionParameters{Direction = @direction});
		}

		///<summary>Set the fan rotation.</summary>
		///<param name="target">The IEnumerable<FanEntity> to call this service for</param>
		///<param name="direction">The direction to rotate.</param>
		public static void SetDirection(this IEnumerable<FanEntity> target, object @direction)
		{
			target.CallService("set_direction", new FanSetDirectionParameters{Direction = @direction});
		}

		///<summary>Set fan speed percentage.</summary>
		public static void SetPercentage(this FanEntity target, FanSetPercentageParameters data)
		{
			target.CallService("set_percentage", data);
		}

		///<summary>Set fan speed percentage.</summary>
		public static void SetPercentage(this IEnumerable<FanEntity> target, FanSetPercentageParameters data)
		{
			target.CallService("set_percentage", data);
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The FanEntity to call this service for</param>
		///<param name="percentage">Percentage speed setting.</param>
		public static void SetPercentage(this FanEntity target, long @percentage)
		{
			target.CallService("set_percentage", new FanSetPercentageParameters{Percentage = @percentage});
		}

		///<summary>Set fan speed percentage.</summary>
		///<param name="target">The IEnumerable<FanEntity> to call this service for</param>
		///<param name="percentage">Percentage speed setting.</param>
		public static void SetPercentage(this IEnumerable<FanEntity> target, long @percentage)
		{
			target.CallService("set_percentage", new FanSetPercentageParameters{Percentage = @percentage});
		}

		///<summary>Set preset mode for a fan device.</summary>
		public static void SetPresetMode(this FanEntity target, FanSetPresetModeParameters data)
		{
			target.CallService("set_preset_mode", data);
		}

		///<summary>Set preset mode for a fan device.</summary>
		public static void SetPresetMode(this IEnumerable<FanEntity> target, FanSetPresetModeParameters data)
		{
			target.CallService("set_preset_mode", data);
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The FanEntity to call this service for</param>
		///<param name="presetMode">New value of preset mode. eg: auto</param>
		public static void SetPresetMode(this FanEntity target, string @presetMode)
		{
			target.CallService("set_preset_mode", new FanSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Set preset mode for a fan device.</summary>
		///<param name="target">The IEnumerable<FanEntity> to call this service for</param>
		///<param name="presetMode">New value of preset mode. eg: auto</param>
		public static void SetPresetMode(this IEnumerable<FanEntity> target, string @presetMode)
		{
			target.CallService("set_preset_mode", new FanSetPresetModeParameters{PresetMode = @presetMode});
		}

		///<summary>Toggle the fan on/off.</summary>
		public static void Toggle(this FanEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle the fan on/off.</summary>
		public static void Toggle(this IEnumerable<FanEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn fan off.</summary>
		public static void TurnOff(this FanEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn fan off.</summary>
		public static void TurnOff(this IEnumerable<FanEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn fan on.</summary>
		public static void TurnOn(this FanEntity target, FanTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Turn fan on.</summary>
		public static void TurnOn(this IEnumerable<FanEntity> target, FanTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The FanEntity to call this service for</param>
		///<param name="speed">Speed setting. eg: high</param>
		///<param name="percentage">Percentage speed setting.</param>
		///<param name="presetMode">Preset mode setting. eg: auto</param>
		public static void TurnOn(this FanEntity target, string? @speed = null, long? @percentage = null, string? @presetMode = null)
		{
			target.CallService("turn_on", new FanTurnOnParameters{Speed = @speed, Percentage = @percentage, PresetMode = @presetMode});
		}

		///<summary>Turn fan on.</summary>
		///<param name="target">The IEnumerable<FanEntity> to call this service for</param>
		///<param name="speed">Speed setting. eg: high</param>
		///<param name="percentage">Percentage speed setting.</param>
		///<param name="presetMode">Preset mode setting. eg: auto</param>
		public static void TurnOn(this IEnumerable<FanEntity> target, string? @speed = null, long? @percentage = null, string? @presetMode = null)
		{
			target.CallService("turn_on", new FanTurnOnParameters{Speed = @speed, Percentage = @percentage, PresetMode = @presetMode});
		}
	}

	public static class HueEntityExtensionMethods
	{
		///<summary>Activate a Hue scene with more control over the options.</summary>
		public static void ActivateScene(this SceneEntity target, HueActivateSceneParameters data)
		{
			target.CallService("activate_scene", data);
		}

		///<summary>Activate a Hue scene with more control over the options.</summary>
		public static void ActivateScene(this IEnumerable<SceneEntity> target, HueActivateSceneParameters data)
		{
			target.CallService("activate_scene", data);
		}

		///<summary>Activate a Hue scene with more control over the options.</summary>
		///<param name="target">The SceneEntity to call this service for</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		///<param name="dynamic">Enable dynamic mode of the scene.</param>
		///<param name="speed">Speed of dynamic palette for this scene</param>
		///<param name="brightness">Set brightness for the scene.</param>
		public static void ActivateScene(this SceneEntity target, long? @transition = null, bool? @dynamic = null, long? @speed = null, long? @brightness = null)
		{
			target.CallService("activate_scene", new HueActivateSceneParameters{Transition = @transition, Dynamic = @dynamic, Speed = @speed, Brightness = @brightness});
		}

		///<summary>Activate a Hue scene with more control over the options.</summary>
		///<param name="target">The IEnumerable<SceneEntity> to call this service for</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		///<param name="dynamic">Enable dynamic mode of the scene.</param>
		///<param name="speed">Speed of dynamic palette for this scene</param>
		///<param name="brightness">Set brightness for the scene.</param>
		public static void ActivateScene(this IEnumerable<SceneEntity> target, long? @transition = null, bool? @dynamic = null, long? @speed = null, long? @brightness = null)
		{
			target.CallService("activate_scene", new HueActivateSceneParameters{Transition = @transition, Dynamic = @dynamic, Speed = @speed, Brightness = @brightness});
		}
	}

	public static class InputBooleanEntityExtensionMethods
	{
		///<summary>Toggle an input boolean</summary>
		public static void Toggle(this InputBooleanEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle an input boolean</summary>
		public static void Toggle(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn off an input boolean</summary>
		public static void TurnOff(this InputBooleanEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn off an input boolean</summary>
		public static void TurnOff(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn on an input boolean</summary>
		public static void TurnOn(this InputBooleanEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn on an input boolean</summary>
		public static void TurnOn(this IEnumerable<InputBooleanEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class InputDatetimeEntityExtensionMethods
	{
		///<summary>This can be used to dynamically set the date and/or time.</summary>
		public static void SetDatetime(this InputDatetimeEntity target, InputDatetimeSetDatetimeParameters data)
		{
			target.CallService("set_datetime", data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		public static void SetDatetime(this IEnumerable<InputDatetimeEntity> target, InputDatetimeSetDatetimeParameters data)
		{
			target.CallService("set_datetime", data);
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The InputDatetimeEntity to call this service for</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public static void SetDatetime(this InputDatetimeEntity target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			target.CallService("set_datetime", new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}

		///<summary>This can be used to dynamically set the date and/or time.</summary>
		///<param name="target">The IEnumerable<InputDatetimeEntity> to call this service for</param>
		///<param name="date">The target date the entity should be set to. eg: "2019-04-20"</param>
		///<param name="time">The target time the entity should be set to. eg: "05:04:20"</param>
		///<param name="datetime">The target date & time the entity should be set to. eg: "2019-04-20 05:04:20"</param>
		///<param name="timestamp">The target date & time the entity should be set to as expressed by a UNIX timestamp.</param>
		public static void SetDatetime(this IEnumerable<InputDatetimeEntity> target, string? @date = null, DateTime? @time = null, string? @datetime = null, long? @timestamp = null)
		{
			target.CallService("set_datetime", new InputDatetimeSetDatetimeParameters{Date = @date, Time = @time, Datetime = @datetime, Timestamp = @timestamp});
		}
	}

	public static class InputNumberEntityExtensionMethods
	{
		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		public static void Decrement(this InputNumberEntity target)
		{
			target.CallService("decrement");
		}

		///<summary>Decrement the value of an input number entity by its stepping.</summary>
		public static void Decrement(this IEnumerable<InputNumberEntity> target)
		{
			target.CallService("decrement");
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		public static void Increment(this InputNumberEntity target)
		{
			target.CallService("increment");
		}

		///<summary>Increment the value of an input number entity by its stepping.</summary>
		public static void Increment(this IEnumerable<InputNumberEntity> target)
		{
			target.CallService("increment");
		}

		///<summary>Set the value of an input number entity.</summary>
		public static void SetValue(this InputNumberEntity target, InputNumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of an input number entity.</summary>
		public static void SetValue(this IEnumerable<InputNumberEntity> target, InputNumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The InputNumberEntity to call this service for</param>
		///<param name="value">The target value the entity should be set to.</param>
		public static void SetValue(this InputNumberEntity target, double @value)
		{
			target.CallService("set_value", new InputNumberSetValueParameters{Value = @value});
		}

		///<summary>Set the value of an input number entity.</summary>
		///<param name="target">The IEnumerable<InputNumberEntity> to call this service for</param>
		///<param name="value">The target value the entity should be set to.</param>
		public static void SetValue(this IEnumerable<InputNumberEntity> target, double @value)
		{
			target.CallService("set_value", new InputNumberSetValueParameters{Value = @value});
		}
	}

	public static class LightEntityExtensionMethods
	{
		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		public static void Toggle(this LightEntity target, LightToggleParameters data)
		{
			target.CallService("toggle", data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		public static void Toggle(this IEnumerable<LightEntity> target, LightToggleParameters data)
		{
			target.CallService("toggle", data);
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void Toggle(this LightEntity target, long? @transition = null, object? @rgbColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("toggle", new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Toggles one or more lights, from on to off, or, off to on, based on their current state. </summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">Color for the light in RGB-format. eg: [255, 100, 100]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="whiteValue">Number indicating level of white.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void Toggle(this IEnumerable<LightEntity> target, long? @transition = null, object? @rgbColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @whiteValue = null, long? @brightness = null, long? @brightnessPct = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("toggle", new LightToggleParameters{Transition = @transition, RgbColor = @rgbColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, WhiteValue = @whiteValue, Brightness = @brightness, BrightnessPct = @brightnessPct, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turns off one or more lights.</summary>
		public static void TurnOff(this LightEntity target, LightTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Turns off one or more lights.</summary>
		public static void TurnOff(this IEnumerable<LightEntity> target, LightTurnOffParameters data)
		{
			target.CallService("turn_off", data);
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public static void TurnOff(this LightEntity target, long? @transition = null, object? @flash = null)
		{
			target.CallService("turn_off", new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turns off one or more lights.</summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="flash">If the light should flash.</param>
		public static void TurnOff(this IEnumerable<LightEntity> target, long? @transition = null, object? @flash = null)
		{
			target.CallService("turn_off", new LightTurnOffParameters{Transition = @transition, Flash = @flash});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		public static void TurnOn(this LightEntity target, LightTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		public static void TurnOn(this IEnumerable<LightEntity> target, LightTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The LightEntity to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">The color for the light (based on RGB - red, green, blue).</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void TurnOn(this LightEntity target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("turn_on", new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}

		///<summary>Turn on one or more lights and adjust properties of the light, even when they are turned on already. </summary>
		///<param name="target">The IEnumerable<LightEntity> to call this service for</param>
		///<param name="transition">Duration it takes to get to next state.</param>
		///<param name="rgbColor">The color for the light (based on RGB - red, green, blue).</param>
		///<param name="rgbwColor">A list containing four integers between 0 and 255 representing the RGBW (red, green, blue, white) color for the light. eg: [255, 100, 100, 50]</param>
		///<param name="rgbwwColor">A list containing five integers between 0 and 255 representing the RGBWW (red, green, blue, cold white, warm white) color for the light. eg: [255, 100, 100, 50, 70]</param>
		///<param name="colorName">A human readable color name.</param>
		///<param name="hsColor">Color for the light in hue/sat format. Hue is 0-360 and Sat is 0-100. eg: [300, 70]</param>
		///<param name="xyColor">Color for the light in XY-format. eg: [0.52, 0.43]</param>
		///<param name="colorTemp">Color temperature for the light in mireds.</param>
		///<param name="kelvin">Color temperature for the light in Kelvin.</param>
		///<param name="brightness">Number indicating brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="brightnessPct">Number indicating percentage of full brightness, where 0 turns the light off, 1 is the minimum brightness and 100 is the maximum brightness supported by the light.</param>
		///<param name="brightnessStep">Change brightness by an amount.</param>
		///<param name="brightnessStepPct">Change brightness by a percentage.</param>
		///<param name="white">Set the light to white mode and change its brightness, where 0 turns the light off, 1 is the minimum brightness and 255 is the maximum brightness supported by the light.</param>
		///<param name="profile">Name of a light profile to use. eg: relax</param>
		///<param name="flash">If the light should flash.</param>
		///<param name="effect">Light effect.</param>
		public static void TurnOn(this IEnumerable<LightEntity> target, long? @transition = null, object? @rgbColor = null, object? @rgbwColor = null, object? @rgbwwColor = null, object? @colorName = null, object? @hsColor = null, object? @xyColor = null, object? @colorTemp = null, long? @kelvin = null, long? @brightness = null, long? @brightnessPct = null, long? @brightnessStep = null, long? @brightnessStepPct = null, long? @white = null, string? @profile = null, object? @flash = null, string? @effect = null)
		{
			target.CallService("turn_on", new LightTurnOnParameters{Transition = @transition, RgbColor = @rgbColor, RgbwColor = @rgbwColor, RgbwwColor = @rgbwwColor, ColorName = @colorName, HsColor = @hsColor, XyColor = @xyColor, ColorTemp = @colorTemp, Kelvin = @kelvin, Brightness = @brightness, BrightnessPct = @brightnessPct, BrightnessStep = @brightnessStep, BrightnessStepPct = @brightnessStepPct, White = @white, Profile = @profile, Flash = @flash, Effect = @effect});
		}
	}

	public static class MediaPlayerEntityExtensionMethods
	{
		///<summary>Send the media player the command to clear players playlist.</summary>
		public static void ClearPlaylist(this MediaPlayerEntity target)
		{
			target.CallService("clear_playlist");
		}

		///<summary>Send the media player the command to clear players playlist.</summary>
		public static void ClearPlaylist(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("clear_playlist");
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		public static void Join(this MediaPlayerEntity target, MediaPlayerJoinParameters data)
		{
			target.CallService("join", data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		public static void Join(this IEnumerable<MediaPlayerEntity> target, MediaPlayerJoinParameters data)
		{
			target.CallService("join", data);
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2","media_player.multiroom_player3"]</param>
		public static void Join(this MediaPlayerEntity target, object? @groupMembers = null)
		{
			target.CallService("join", new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Group players together. Only works on platforms with support for player groups.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="groupMembers">The players which will be synced with the target player. eg: ["media_player.multiroom_player2","media_player.multiroom_player3"]</param>
		public static void Join(this IEnumerable<MediaPlayerEntity> target, object? @groupMembers = null)
		{
			target.CallService("join", new MediaPlayerJoinParameters{GroupMembers = @groupMembers});
		}

		///<summary>Send the media player the command for next track.</summary>
		public static void MediaNextTrack(this MediaPlayerEntity target)
		{
			target.CallService("media_next_track");
		}

		///<summary>Send the media player the command for next track.</summary>
		public static void MediaNextTrack(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_next_track");
		}

		///<summary>Send the media player the command for pause.</summary>
		public static void MediaPause(this MediaPlayerEntity target)
		{
			target.CallService("media_pause");
		}

		///<summary>Send the media player the command for pause.</summary>
		public static void MediaPause(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_pause");
		}

		///<summary>Send the media player the command for play.</summary>
		public static void MediaPlay(this MediaPlayerEntity target)
		{
			target.CallService("media_play");
		}

		///<summary>Send the media player the command for play.</summary>
		public static void MediaPlay(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_play");
		}

		///<summary>Toggle media player play/pause state.</summary>
		public static void MediaPlayPause(this MediaPlayerEntity target)
		{
			target.CallService("media_play_pause");
		}

		///<summary>Toggle media player play/pause state.</summary>
		public static void MediaPlayPause(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_play_pause");
		}

		///<summary>Send the media player the command for previous track.</summary>
		public static void MediaPreviousTrack(this MediaPlayerEntity target)
		{
			target.CallService("media_previous_track");
		}

		///<summary>Send the media player the command for previous track.</summary>
		public static void MediaPreviousTrack(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_previous_track");
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		public static void MediaSeek(this MediaPlayerEntity target, MediaPlayerMediaSeekParameters data)
		{
			target.CallService("media_seek", data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		public static void MediaSeek(this IEnumerable<MediaPlayerEntity> target, MediaPlayerMediaSeekParameters data)
		{
			target.CallService("media_seek", data);
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public static void MediaSeek(this MediaPlayerEntity target, double @seekPosition)
		{
			target.CallService("media_seek", new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the command to seek in current playing media.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="seekPosition">Position to seek to. The format is platform dependent.</param>
		public static void MediaSeek(this IEnumerable<MediaPlayerEntity> target, double @seekPosition)
		{
			target.CallService("media_seek", new MediaPlayerMediaSeekParameters{SeekPosition = @seekPosition});
		}

		///<summary>Send the media player the stop command.</summary>
		public static void MediaStop(this MediaPlayerEntity target)
		{
			target.CallService("media_stop");
		}

		///<summary>Send the media player the stop command.</summary>
		public static void MediaStop(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("media_stop");
		}

		///<summary>Send the media player the command for playing media.</summary>
		public static void PlayMedia(this MediaPlayerEntity target, MediaPlayerPlayMediaParameters data)
		{
			target.CallService("play_media", data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		public static void PlayMedia(this IEnumerable<MediaPlayerEntity> target, MediaPlayerPlayMediaParameters data)
		{
			target.CallService("play_media", data);
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		///<param name="enqueue">If the content should be played now or be added to the queue.</param>
		///<param name="announce">If the media should be played as an announcement. eg: true</param>
		public static void PlayMedia(this MediaPlayerEntity target, string @mediaContentId, string @mediaContentType, object? @enqueue = null, bool? @announce = null)
		{
			target.CallService("play_media", new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType, Enqueue = @enqueue, Announce = @announce});
		}

		///<summary>Send the media player the command for playing media.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="mediaContentId">The ID of the content to play. Platform dependent. eg: https://home-assistant.io/images/cast/splash.png</param>
		///<param name="mediaContentType">The type of the content to play. Like image, music, tvshow, video, episode, channel or playlist. eg: music</param>
		///<param name="enqueue">If the content should be played now or be added to the queue.</param>
		///<param name="announce">If the media should be played as an announcement. eg: true</param>
		public static void PlayMedia(this IEnumerable<MediaPlayerEntity> target, string @mediaContentId, string @mediaContentType, object? @enqueue = null, bool? @announce = null)
		{
			target.CallService("play_media", new MediaPlayerPlayMediaParameters{MediaContentId = @mediaContentId, MediaContentType = @mediaContentType, Enqueue = @enqueue, Announce = @announce});
		}

		///<summary>Set repeat mode</summary>
		public static void RepeatSet(this MediaPlayerEntity target, MediaPlayerRepeatSetParameters data)
		{
			target.CallService("repeat_set", data);
		}

		///<summary>Set repeat mode</summary>
		public static void RepeatSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerRepeatSetParameters data)
		{
			target.CallService("repeat_set", data);
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="repeat">Repeat mode to set.</param>
		public static void RepeatSet(this MediaPlayerEntity target, object @repeat)
		{
			target.CallService("repeat_set", new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Set repeat mode</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="repeat">Repeat mode to set.</param>
		public static void RepeatSet(this IEnumerable<MediaPlayerEntity> target, object @repeat)
		{
			target.CallService("repeat_set", new MediaPlayerRepeatSetParameters{Repeat = @repeat});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		public static void SelectSoundMode(this MediaPlayerEntity target, MediaPlayerSelectSoundModeParameters data)
		{
			target.CallService("select_sound_mode", data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		public static void SelectSoundMode(this IEnumerable<MediaPlayerEntity> target, MediaPlayerSelectSoundModeParameters data)
		{
			target.CallService("select_sound_mode", data);
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public static void SelectSoundMode(this MediaPlayerEntity target, string? @soundMode = null)
		{
			target.CallService("select_sound_mode", new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change sound mode.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="soundMode">Name of the sound mode to switch to. eg: Music</param>
		public static void SelectSoundMode(this IEnumerable<MediaPlayerEntity> target, string? @soundMode = null)
		{
			target.CallService("select_sound_mode", new MediaPlayerSelectSoundModeParameters{SoundMode = @soundMode});
		}

		///<summary>Send the media player the command to change input source.</summary>
		public static void SelectSource(this MediaPlayerEntity target, MediaPlayerSelectSourceParameters data)
		{
			target.CallService("select_source", data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		public static void SelectSource(this IEnumerable<MediaPlayerEntity> target, MediaPlayerSelectSourceParameters data)
		{
			target.CallService("select_source", data);
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public static void SelectSource(this MediaPlayerEntity target, string @source)
		{
			target.CallService("select_source", new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Send the media player the command to change input source.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="source">Name of the source to switch to. Platform dependent. eg: video1</param>
		public static void SelectSource(this IEnumerable<MediaPlayerEntity> target, string @source)
		{
			target.CallService("select_source", new MediaPlayerSelectSourceParameters{Source = @source});
		}

		///<summary>Set shuffling state.</summary>
		public static void ShuffleSet(this MediaPlayerEntity target, MediaPlayerShuffleSetParameters data)
		{
			target.CallService("shuffle_set", data);
		}

		///<summary>Set shuffling state.</summary>
		public static void ShuffleSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerShuffleSetParameters data)
		{
			target.CallService("shuffle_set", data);
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public static void ShuffleSet(this MediaPlayerEntity target, bool @shuffle)
		{
			target.CallService("shuffle_set", new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Set shuffling state.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="shuffle">True/false for enabling/disabling shuffle.</param>
		public static void ShuffleSet(this IEnumerable<MediaPlayerEntity> target, bool @shuffle)
		{
			target.CallService("shuffle_set", new MediaPlayerShuffleSetParameters{Shuffle = @shuffle});
		}

		///<summary>Toggles a media player power state.</summary>
		public static void Toggle(this MediaPlayerEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggles a media player power state.</summary>
		public static void Toggle(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn a media player power off.</summary>
		public static void TurnOff(this MediaPlayerEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a media player power off.</summary>
		public static void TurnOff(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a media player power on.</summary>
		public static void TurnOn(this MediaPlayerEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn a media player power on.</summary>
		public static void TurnOn(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("turn_on");
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		public static void Unjoin(this MediaPlayerEntity target)
		{
			target.CallService("unjoin");
		}

		///<summary>Unjoin the player from a group. Only works on platforms with support for player groups.</summary>
		public static void Unjoin(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("unjoin");
		}

		///<summary>Turn a media player volume down.</summary>
		public static void VolumeDown(this MediaPlayerEntity target)
		{
			target.CallService("volume_down");
		}

		///<summary>Turn a media player volume down.</summary>
		public static void VolumeDown(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("volume_down");
		}

		///<summary>Mute a media player's volume.</summary>
		public static void VolumeMute(this MediaPlayerEntity target, MediaPlayerVolumeMuteParameters data)
		{
			target.CallService("volume_mute", data);
		}

		///<summary>Mute a media player's volume.</summary>
		public static void VolumeMute(this IEnumerable<MediaPlayerEntity> target, MediaPlayerVolumeMuteParameters data)
		{
			target.CallService("volume_mute", data);
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public static void VolumeMute(this MediaPlayerEntity target, bool @isVolumeMuted)
		{
			target.CallService("volume_mute", new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Mute a media player's volume.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="isVolumeMuted">True/false for mute/unmute.</param>
		public static void VolumeMute(this IEnumerable<MediaPlayerEntity> target, bool @isVolumeMuted)
		{
			target.CallService("volume_mute", new MediaPlayerVolumeMuteParameters{IsVolumeMuted = @isVolumeMuted});
		}

		///<summary>Set a media player's volume level.</summary>
		public static void VolumeSet(this MediaPlayerEntity target, MediaPlayerVolumeSetParameters data)
		{
			target.CallService("volume_set", data);
		}

		///<summary>Set a media player's volume level.</summary>
		public static void VolumeSet(this IEnumerable<MediaPlayerEntity> target, MediaPlayerVolumeSetParameters data)
		{
			target.CallService("volume_set", data);
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The MediaPlayerEntity to call this service for</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public static void VolumeSet(this MediaPlayerEntity target, double @volumeLevel)
		{
			target.CallService("volume_set", new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Set a media player's volume level.</summary>
		///<param name="target">The IEnumerable<MediaPlayerEntity> to call this service for</param>
		///<param name="volumeLevel">Volume level to set as float.</param>
		public static void VolumeSet(this IEnumerable<MediaPlayerEntity> target, double @volumeLevel)
		{
			target.CallService("volume_set", new MediaPlayerVolumeSetParameters{VolumeLevel = @volumeLevel});
		}

		///<summary>Turn a media player volume up.</summary>
		public static void VolumeUp(this MediaPlayerEntity target)
		{
			target.CallService("volume_up");
		}

		///<summary>Turn a media player volume up.</summary>
		public static void VolumeUp(this IEnumerable<MediaPlayerEntity> target)
		{
			target.CallService("volume_up");
		}
	}

	public static class NumberEntityExtensionMethods
	{
		///<summary>Set the value of a Number entity.</summary>
		public static void SetValue(this NumberEntity target, NumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of a Number entity.</summary>
		public static void SetValue(this IEnumerable<NumberEntity> target, NumberSetValueParameters data)
		{
			target.CallService("set_value", data);
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The NumberEntity to call this service for</param>
		///<param name="value">The target value the entity should be set to. eg: 42</param>
		public static void SetValue(this NumberEntity target, string? @value = null)
		{
			target.CallService("set_value", new NumberSetValueParameters{Value = @value});
		}

		///<summary>Set the value of a Number entity.</summary>
		///<param name="target">The IEnumerable<NumberEntity> to call this service for</param>
		///<param name="value">The target value the entity should be set to. eg: 42</param>
		public static void SetValue(this IEnumerable<NumberEntity> target, string? @value = null)
		{
			target.CallService("set_value", new NumberSetValueParameters{Value = @value});
		}
	}

	public static class SceneEntityExtensionMethods
	{
		///<summary>Activate a scene.</summary>
		public static void TurnOn(this SceneEntity target, SceneTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Activate a scene.</summary>
		public static void TurnOn(this IEnumerable<SceneEntity> target, SceneTurnOnParameters data)
		{
			target.CallService("turn_on", data);
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The SceneEntity to call this service for</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public static void TurnOn(this SceneEntity target, long? @transition = null)
		{
			target.CallService("turn_on", new SceneTurnOnParameters{Transition = @transition});
		}

		///<summary>Activate a scene.</summary>
		///<param name="target">The IEnumerable<SceneEntity> to call this service for</param>
		///<param name="transition">Transition duration it takes to bring devices to the state defined in the scene.</param>
		public static void TurnOn(this IEnumerable<SceneEntity> target, long? @transition = null)
		{
			target.CallService("turn_on", new SceneTurnOnParameters{Transition = @transition});
		}
	}

	public static class ScriptEntityExtensionMethods
	{
		///<summary>Toggle script</summary>
		public static void Toggle(this ScriptEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggle script</summary>
		public static void Toggle(this IEnumerable<ScriptEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn off script</summary>
		public static void TurnOff(this ScriptEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn off script</summary>
		public static void TurnOff(this IEnumerable<ScriptEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn on script</summary>
		public static void TurnOn(this ScriptEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn on script</summary>
		public static void TurnOn(this IEnumerable<ScriptEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class SelectEntityExtensionMethods
	{
		///<summary>Select an option of an select entity.</summary>
		public static void SelectOption(this SelectEntity target, SelectSelectOptionParameters data)
		{
			target.CallService("select_option", data);
		}

		///<summary>Select an option of an select entity.</summary>
		public static void SelectOption(this IEnumerable<SelectEntity> target, SelectSelectOptionParameters data)
		{
			target.CallService("select_option", data);
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The SelectEntity to call this service for</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public static void SelectOption(this SelectEntity target, string @option)
		{
			target.CallService("select_option", new SelectSelectOptionParameters{Option = @option});
		}

		///<summary>Select an option of an select entity.</summary>
		///<param name="target">The IEnumerable<SelectEntity> to call this service for</param>
		///<param name="option">Option to be selected. eg: "Item A"</param>
		public static void SelectOption(this IEnumerable<SelectEntity> target, string @option)
		{
			target.CallService("select_option", new SelectSelectOptionParameters{Option = @option});
		}
	}

	public static class SwitchEntityExtensionMethods
	{
		///<summary>Toggles a switch state</summary>
		public static void Toggle(this SwitchEntity target)
		{
			target.CallService("toggle");
		}

		///<summary>Toggles a switch state</summary>
		public static void Toggle(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("toggle");
		}

		///<summary>Turn a switch off</summary>
		public static void TurnOff(this SwitchEntity target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a switch off</summary>
		public static void TurnOff(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("turn_off");
		}

		///<summary>Turn a switch on</summary>
		public static void TurnOn(this SwitchEntity target)
		{
			target.CallService("turn_on");
		}

		///<summary>Turn a switch on</summary>
		public static void TurnOn(this IEnumerable<SwitchEntity> target)
		{
			target.CallService("turn_on");
		}
	}

	public static class UpdateEntityExtensionMethods
	{
		///<summary>Removes the skipped version marker from an update.</summary>
		public static void ClearSkipped(this UpdateEntity target)
		{
			target.CallService("clear_skipped");
		}

		///<summary>Removes the skipped version marker from an update.</summary>
		public static void ClearSkipped(this IEnumerable<UpdateEntity> target)
		{
			target.CallService("clear_skipped");
		}

		///<summary>Install an update for this device or service</summary>
		public static void Install(this UpdateEntity target, UpdateInstallParameters data)
		{
			target.CallService("install", data);
		}

		///<summary>Install an update for this device or service</summary>
		public static void Install(this IEnumerable<UpdateEntity> target, UpdateInstallParameters data)
		{
			target.CallService("install", data);
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The UpdateEntity to call this service for</param>
		///<param name="version">Version to install, if omitted, the latest version will be installed. eg: 1.0.0</param>
		///<param name="backup">Backup before installing the update, if supported by the integration.</param>
		public static void Install(this UpdateEntity target, string? @version = null, bool? @backup = null)
		{
			target.CallService("install", new UpdateInstallParameters{Version = @version, Backup = @backup});
		}

		///<summary>Install an update for this device or service</summary>
		///<param name="target">The IEnumerable<UpdateEntity> to call this service for</param>
		///<param name="version">Version to install, if omitted, the latest version will be installed. eg: 1.0.0</param>
		///<param name="backup">Backup before installing the update, if supported by the integration.</param>
		public static void Install(this IEnumerable<UpdateEntity> target, string? @version = null, bool? @backup = null)
		{
			target.CallService("install", new UpdateInstallParameters{Version = @version, Backup = @backup});
		}

		///<summary>Mark currently available update as skipped.</summary>
		public static void Skip(this UpdateEntity target)
		{
			target.CallService("skip");
		}

		///<summary>Mark currently available update as skipped.</summary>
		public static void Skip(this IEnumerable<UpdateEntity> target)
		{
			target.CallService("skip");
		}
	}

	public static class ZwaveJsEntityExtensionMethods
	{
		///<summary>Resets the meter(s) on a node.</summary>
		public static void ResetMeter(this SensorEntity target, ZwaveJsResetMeterParameters data)
		{
			target.CallService("reset_meter", data);
		}

		///<summary>Resets the meter(s) on a node.</summary>
		public static void ResetMeter(this IEnumerable<SensorEntity> target, ZwaveJsResetMeterParameters data)
		{
			target.CallService("reset_meter", data);
		}

		///<summary>Resets the meter(s) on a node.</summary>
		///<param name="target">The SensorEntity to call this service for</param>
		///<param name="meterType">The type of meter to reset. Not all meters support the ability to pick a meter type to reset. eg: 1</param>
		///<param name="value">The value that meter(s) should be reset to. Not all meters support the ability to be reset to a specific value. eg: 5</param>
		public static void ResetMeter(this SensorEntity target, string? @meterType = null, string? @value = null)
		{
			target.CallService("reset_meter", new ZwaveJsResetMeterParameters{MeterType = @meterType, Value = @value});
		}

		///<summary>Resets the meter(s) on a node.</summary>
		///<param name="target">The IEnumerable<SensorEntity> to call this service for</param>
		///<param name="meterType">The type of meter to reset. Not all meters support the ability to pick a meter type to reset. eg: 1</param>
		///<param name="value">The value that meter(s) should be reset to. Not all meters support the ability to be reset to a specific value. eg: 5</param>
		public static void ResetMeter(this IEnumerable<SensorEntity> target, string? @meterType = null, string? @value = null)
		{
			target.CallService("reset_meter", new ZwaveJsResetMeterParameters{MeterType = @meterType, Value = @value});
		}
	}
}