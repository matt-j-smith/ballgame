using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Ballgame
{
    	[XmlRoot(ElementName="gallery")]
	public class Gallery {
		[XmlAttribute(AttributeName="exists")]
		public string Exists { get; set; }
	}

	[XmlRoot(ElementName="home")]
	public class Home {
		[XmlElement(ElementName="tv")]
		public string Tv { get; set; }
		[XmlElement(ElementName="radio")]
		public string Radio { get; set; }
		[XmlElement(ElementName="player_id")]
		public string Player_id { get; set; }
		[XmlElement(ElementName="useName")]
		public string UseName { get; set; }
		[XmlElement(ElementName="lastName")]
		public string LastName { get; set; }
		[XmlElement(ElementName="rosterDisplayName")]
		public string RosterDisplayName { get; set; }
		[XmlElement(ElementName="number")]
		public string Number { get; set; }
		[XmlElement(ElementName="throwinghand")]
		public string Throwinghand { get; set; }
		[XmlElement(ElementName="wins")]
		public string Wins { get; set; }
		[XmlElement(ElementName="losses")]
		public string Losses { get; set; }
		[XmlElement(ElementName="era")]
		public string Era { get; set; }
		[XmlElement(ElementName="so")]
		public string So { get; set; }
		[XmlElement(ElementName="std_wins")]
		public string Std_wins { get; set; }
		[XmlElement(ElementName="std_losses")]
		public string Std_losses { get; set; }
		[XmlElement(ElementName="std_era")]
		public string Std_era { get; set; }
		[XmlElement(ElementName="std_so")]
		public string Std_so { get; set; }
		[XmlElement(ElementName="report")]
		public string Report { get; set; }
		[XmlElement(ElementName="relatedvideo")]
		public Relatedvideo Relatedvideo { get; set; }
		[XmlElement(ElementName="headline")]
		public string Headline { get; set; }
		[XmlElement(ElementName="blurb")]
		public string Blurb { get; set; }
		[XmlElement(ElementName="url")]
		public Url Url { get; set; }
		[XmlElement(ElementName="photos")]
		public Photos Photos { get; set; }
		[XmlElement(ElementName="video_index")]
		public Video_index Video_index { get; set; }
	}

	[XmlRoot(ElementName="away")]
	public class Away {
		[XmlElement(ElementName="tv")]
		public string Tv { get; set; }
		[XmlElement(ElementName="radio")]
		public string Radio { get; set; }
		[XmlElement(ElementName="player_id")]
		public string Player_id { get; set; }
		[XmlElement(ElementName="useName")]
		public string UseName { get; set; }
		[XmlElement(ElementName="lastName")]
		public string LastName { get; set; }
		[XmlElement(ElementName="rosterDisplayName")]
		public string RosterDisplayName { get; set; }
		[XmlElement(ElementName="number")]
		public string Number { get; set; }
		[XmlElement(ElementName="throwinghand")]
		public string Throwinghand { get; set; }
		[XmlElement(ElementName="wins")]
		public string Wins { get; set; }
		[XmlElement(ElementName="losses")]
		public string Losses { get; set; }
		[XmlElement(ElementName="era")]
		public string Era { get; set; }
		[XmlElement(ElementName="so")]
		public string So { get; set; }
		[XmlElement(ElementName="std_wins")]
		public string Std_wins { get; set; }
		[XmlElement(ElementName="std_losses")]
		public string Std_losses { get; set; }
		[XmlElement(ElementName="std_era")]
		public string Std_era { get; set; }
		[XmlElement(ElementName="std_so")]
		public string Std_so { get; set; }
		[XmlElement(ElementName="report")]
		public string Report { get; set; }
		[XmlElement(ElementName="relatedvideo")]
		public Relatedvideo Relatedvideo { get; set; }
		[XmlElement(ElementName="headline")]
		public string Headline { get; set; }
		[XmlElement(ElementName="blurb")]
		public string Blurb { get; set; }
		[XmlElement(ElementName="url")]
		public Url Url { get; set; }
		[XmlElement(ElementName="photos")]
		public Photos Photos { get; set; }
		[XmlElement(ElementName="video_index")]
		public Video_index Video_index { get; set; }
	}

	[XmlRoot(ElementName="broadcast")]
	public class Broadcast {
		[XmlElement(ElementName="home")]
		public Home Home { get; set; }
		[XmlElement(ElementName="away")]
		public Away Away { get; set; }
	}

	[XmlRoot(ElementName="media")]
	public class gcMedia {
		[XmlElement(ElementName="title")]
		public string Title { get; set; }
		[XmlAttribute(AttributeName="content_id")]
		public string Content_id { get; set; }
		[XmlElement(ElementName="duration")]
		public string Duration { get; set; }
		[XmlElement(ElementName="meta")]
		public Meta Meta { get; set; }
		[XmlElement(ElementName="url")]
		public List<Url> Url { get; set; }
		[XmlElement(ElementName="thumbnail")]
		public string Thumbnail { get; set; }
		[XmlAttribute(AttributeName="pid")]
		public string Pid { get; set; }
		[XmlAttribute(AttributeName="type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName="free")]
		public string Free { get; set; }
		[XmlAttribute(AttributeName="feed-code")]
		public string Feedcode { get; set; }
		[XmlAttribute(AttributeName="dds-id")]
		public string Ddsid { get; set; }
		[XmlAttribute(AttributeName="date")]
		public string Date { get; set; }
		[XmlAttribute(AttributeName="state")]
		public string State { get; set; }
		[XmlAttribute(AttributeName="game-id")]
		public string Gameid { get; set; }
		[XmlAttribute(AttributeName="blackout")]
		public string Blackout { get; set; }
	}

	[XmlRoot(ElementName="relatedvideo")]
	public class Relatedvideo {
		[XmlElement(ElementName="media")]
		public Media Media { get; set; }
	}

	[XmlRoot(ElementName="probables")]
	public class Probables {
		[XmlElement(ElementName="stats_type")]
		public string Stats_type { get; set; }
		[XmlElement(ElementName="stats_season")]
		public string Stats_season { get; set; }
		[XmlElement(ElementName="home")]
		public Home Home { get; set; }
		[XmlElement(ElementName="away")]
		public Away Away { get; set; }
	}

	[XmlRoot(ElementName="url")]
	public class Url {
		[XmlAttribute(AttributeName="cid")]
		public string Cid { get; set; }
		[XmlText]
		public string Text { get; set; }
		[XmlAttribute(AttributeName="speed")]
		public string Speed { get; set; }
		[XmlAttribute(AttributeName="fid")]
		public string Fid { get; set; }
		[XmlAttribute(AttributeName="w_id")]
		public string W_id { get; set; }
		[XmlAttribute(AttributeName="id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName="authorization")]
		public string Authorization { get; set; }
		[XmlAttribute(AttributeName="login")]
		public string Login { get; set; }
		[XmlAttribute(AttributeName="type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName="gid")]
		public string Gid { get; set; }
		[XmlAttribute(AttributeName="pid")]
		public string Pid { get; set; }
		[XmlAttribute(AttributeName="spons")]
		public string Spons { get; set; }
		[XmlAttribute(AttributeName="vid")]
		public string Vid { get; set; }
		[XmlAttribute(AttributeName="c_url")]
		public string C_url { get; set; }
		[XmlAttribute(AttributeName="mid")]
		public string Mid { get; set; }
		[XmlAttribute(AttributeName="v")]
		public string V { get; set; }
		[XmlAttribute(AttributeName="state")]
		public string State { get; set; }
	}

	[XmlRoot(ElementName="photos")]
	public class Photos {
		[XmlElement(ElementName="url")]
		public string Url { get; set; }
		[XmlElement(ElementName="url_retina")]
		public string Url_retina { get; set; }
		[XmlElement(ElementName="url_ps")]
		public string Url_ps { get; set; }
		[XmlElement(ElementName="url_ps_retina")]
		public string Url_ps_retina { get; set; }
		[XmlElement(ElementName="headline")]
		public string Headline { get; set; }
		[XmlElement(ElementName="ipad")]
		public Ipad Ipad { get; set; }
	}

	[XmlRoot(ElementName="mlb")]
	public class Mlb {
		[XmlElement(ElementName="headline")]
		public string Headline { get; set; }
		[XmlElement(ElementName="blurb")]
		public string Blurb { get; set; }
		[XmlElement(ElementName="url")]
		public Url Url { get; set; }
		[XmlElement(ElementName="photos")]
		public Photos Photos { get; set; }
		[XmlElement(ElementName="video_index")]
		public Video_index Video_index { get; set; }
	}

	[XmlRoot(ElementName="previews")]
	public class Previews {
		[XmlElement(ElementName="mlb")]
		public Mlb Mlb { get; set; }
		[XmlElement(ElementName="home")]
		public Home Home { get; set; }
		[XmlElement(ElementName="away")]
		public Away Away { get; set; }
	}

	[XmlRoot(ElementName="meta")]
	public class Meta {
		[XmlAttribute(AttributeName="content_id")]
		public string Content_id { get; set; }
		[XmlAttribute(AttributeName="link_type")]
		public string Link_type { get; set; }
		[XmlAttribute(AttributeName="view_key")]
		public string View_key { get; set; }
		[XmlAttribute(AttributeName="topic_id")]
		public string Topic_id { get; set; }
		[XmlAttribute(AttributeName="calendar_event_id")]
		public string Calendar_event_id { get; set; }
		[XmlAttribute(AttributeName="duration")]
		public string Duration { get; set; }
	}

	[XmlRoot(ElementName="item")]
	public class Item {
		[XmlElement(ElementName="meta")]
		public Meta Meta { get; set; }
		[XmlElement(ElementName="big_blurb")]
		public string Big_blurb { get; set; }
		[XmlElement(ElementName="blurb")]
		public string Blurb { get; set; }
		[XmlElement(ElementName="headline")]
		public string Headline { get; set; }
		[XmlElement(ElementName="thumb")]
		public string Thumb { get; set; }
		[XmlAttribute(AttributeName="mediaType")]
		public string MediaType { get; set; }
	}

	[XmlRoot(ElementName="urls")]
	public class Urls {
		[XmlElement(ElementName="url")]
		public List<Url> Url { get; set; }
	}

	[XmlRoot(ElementName="video_index")]
	public class Video_index {
		[XmlElement(ElementName="item")]
		public Item Item { get; set; }
		[XmlElement(ElementName="urls")]
		public Urls Urls { get; set; }
	}

	[XmlRoot(ElementName="recaps")]
	public class Recaps {
		[XmlElement(ElementName="home")]
		public Home Home { get; set; }
		[XmlElement(ElementName="away")]
		public Away Away { get; set; }
		[XmlElement(ElementName="mlb")]
		public Mlb Mlb { get; set; }
	}

	[XmlRoot(ElementName="wrap")]
	public class Wrap {
		[XmlElement(ElementName="mlb")]
		public Mlb Mlb { get; set; }
	}

	[XmlRoot(ElementName="ipad")]
	public class Ipad {
		[XmlElement(ElementName="url")]
		public string Url { get; set; }
		[XmlElement(ElementName="url_retina")]
		public string Url_retina { get; set; }
		[XmlElement(ElementName="url_ps")]
		public string Url_ps { get; set; }
		[XmlElement(ElementName="url_ps_retina")]
		public string Url_ps_retina { get; set; }
		[XmlElement(ElementName="headline")]
		public string Headline { get; set; }
		[XmlElement(ElementName="caption")]
		public string Caption { get; set; }
		[XmlElement(ElementName="credit")]
		public string Credit { get; set; }
	}

	[XmlRoot(ElementName="ipad_video")]
	public class Ipad_video {
		[XmlElement(ElementName="media")]
		public Media Media { get; set; }
	}

	[XmlRoot(ElementName="game")]
	public class GameCenterGame {
		[XmlElement(ElementName="ticketlink")]
		public string Ticketlink { get; set; }
		[XmlElement(ElementName="venueShort")]
		public string VenueShort { get; set; }
		[XmlElement(ElementName="venueLong")]
		public string VenueLong { get; set; }
		[XmlElement(ElementName="gallery")]
		public Gallery Gallery { get; set; }
		[XmlElement(ElementName="broadcast")]
		public Broadcast Broadcast { get; set; }
		[XmlElement(ElementName="probables")]
		public Probables Probables { get; set; }
		[XmlElement(ElementName="previews")]
		public Previews Previews { get; set; }
		[XmlElement(ElementName="recaps")]
		public Recaps Recaps { get; set; }
		[XmlElement(ElementName="wrap")]
		public Wrap Wrap { get; set; }
		[XmlElement(ElementName="photos")]
		public Photos Photos { get; set; }
		[XmlElement(ElementName="ipad_video")]
		public Ipad_video Ipad_video { get; set; }
		[XmlAttribute(AttributeName="status")]
		public string Status { get; set; }
		[XmlAttribute(AttributeName="id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName="start_time")]
		public string Start_time { get; set; }
		[XmlAttribute(AttributeName="ampm")]
		public string Ampm { get; set; }
		[XmlAttribute(AttributeName="time_zone")]
		public string Time_zone { get; set; }
		[XmlAttribute(AttributeName="type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName="away_score")]
		public string Away_score { get; set; }
		[XmlAttribute(AttributeName="home_score")]
		public string Home_score { get; set; }
		[XmlAttribute(AttributeName="league")]
		public string League { get; set; }
		[XmlAttribute(AttributeName="series-code")]
		public string Seriescode { get; set; }
		[XmlAttribute(AttributeName="series-game-number")]
		public string Seriesgamenumber { get; set; }
		[XmlAttribute(AttributeName="game-number")]
		public string Gamenumber { get; set; }
	}

}