using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ballgame
{
  [XmlRoot(ElementName="pitch")]
	public class Pitch {
		[XmlAttribute(AttributeName="sv_id")]
		public string Sv_id { get; set; }
		[XmlAttribute(AttributeName="des")]
		public string Des { get; set; }
		[XmlAttribute(AttributeName="des_es")]
		public string Des_es { get; set; }
		[XmlAttribute(AttributeName="type")]
		public string Type { get; set; }
		[XmlAttribute(AttributeName="start_speed")]
		public string Start_speed { get; set; }
		[XmlAttribute(AttributeName="pitch_type")]
		public string Pitch_type { get; set; }
	}

	[XmlRoot(ElementName="atbat")]
	public class Atbat {
		[XmlElement(ElementName="pitch")]
		public List<Pitch> Pitch { get; set; }
		[XmlAttribute(AttributeName="num")]
		public string Num { get; set; }
		[XmlAttribute(AttributeName="b")]
		public string B { get; set; }
		[XmlAttribute(AttributeName="s")]
		public string S { get; set; }
		[XmlAttribute(AttributeName="o")]
		public string O { get; set; }
		[XmlAttribute(AttributeName="start_tfs")]
		public string Start_tfs { get; set; }
		[XmlAttribute(AttributeName="start_tfs_zulu")]
		public string Start_tfs_zulu { get; set; }
		[XmlAttribute(AttributeName="batter")]
		public string Batter { get; set; }
		[XmlAttribute(AttributeName="pitcher")]
		public string Pitcher { get; set; }
		[XmlAttribute(AttributeName="des")]
		public string Des { get; set; }
		[XmlAttribute(AttributeName="des_es")]
		public string Des_es { get; set; }
		[XmlAttribute(AttributeName="event_num")]
		public string Event_num { get; set; }
		[XmlAttribute(AttributeName="event")]
		public string Event { get; set; }
		[XmlAttribute(AttributeName="event_es")]
		public string Event_es { get; set; }
		[XmlAttribute(AttributeName="play_guid")]
		public string Play_guid { get; set; }
		[XmlAttribute(AttributeName="home_team_runs")]
		public string Home_team_runs { get; set; }
		[XmlAttribute(AttributeName="away_team_runs")]
		public string Away_team_runs { get; set; }
		[XmlAttribute(AttributeName="b1")]
		public string B1 { get; set; }
		[XmlAttribute(AttributeName="b2")]
		public string B2 { get; set; }
		[XmlAttribute(AttributeName="b3")]
		public string B3 { get; set; }
		[XmlAttribute(AttributeName="score")]
		public string Score { get; set; }
		[XmlAttribute(AttributeName="rbi")]
		public string Rbi { get; set; }
		[XmlAttribute(AttributeName="event2")]
		public string Event2 { get; set; }
		[XmlAttribute(AttributeName="event2_es")]
		public string Event2_es { get; set; }
	}

	[XmlRoot(ElementName="action")]
	public class Action {
		[XmlAttribute(AttributeName="b")]
		public string B { get; set; }
		[XmlAttribute(AttributeName="s")]
		public string S { get; set; }
		[XmlAttribute(AttributeName="o")]
		public string O { get; set; }
		[XmlAttribute(AttributeName="des")]
		public string Des { get; set; }
		[XmlAttribute(AttributeName="des_es")]
		public string Des_es { get; set; }
		[XmlAttribute(AttributeName="event")]
		public string Event { get; set; }
		[XmlAttribute(AttributeName="event_es")]
		public string Event_es { get; set; }
		[XmlAttribute(AttributeName="tfs")]
		public string Tfs { get; set; }
		[XmlAttribute(AttributeName="tfs_zulu")]
		public string Tfs_zulu { get; set; }
		[XmlAttribute(AttributeName="player")]
		public string Player { get; set; }
		[XmlAttribute(AttributeName="pitch")]
		public string Pitch { get; set; }
		[XmlAttribute(AttributeName="event_num")]
		public string Event_num { get; set; }
		[XmlAttribute(AttributeName="home_team_runs")]
		public string Home_team_runs { get; set; }
		[XmlAttribute(AttributeName="away_team_runs")]
		public string Away_team_runs { get; set; }
		[XmlAttribute(AttributeName="play_guid")]
		public string Play_guid { get; set; }
	}

	[XmlRoot(ElementName="top")]
	public class Top {
		[XmlElement(ElementName="atbat")]
		public List<Atbat> Atbat { get; set; }
		[XmlElement(ElementName="action")]
		public List<Action> Action { get; set; }
	}

	[XmlRoot(ElementName="bottom")]
	public class Bottom {
		[XmlElement(ElementName="action")]
		public List<Action> Action { get; set; }
		[XmlElement(ElementName="atbat")]
		public List<Atbat> Atbat { get; set; }
	}

	[XmlRoot(ElementName="inning")]
	public class Inning {
		[XmlElement(ElementName="top")]
		public Top Top { get; set; }
		[XmlElement(ElementName="bottom")]
		public Bottom Bottom { get; set; }
		[XmlAttribute(AttributeName="num")]
		public string Num { get; set; }
	}

	[XmlRoot(ElementName="atBat")]
	public class AtBat {
		[XmlAttribute(AttributeName="pid")]
		public string Pid { get; set; }
	}

	[XmlRoot(ElementName="deck")]
	public class Deck {
		[XmlAttribute(AttributeName="pid")]
		public string Pid { get; set; }
	}

	[XmlRoot(ElementName="hole")]
	public class Hole {
		[XmlAttribute(AttributeName="pid")]
		public string Pid { get; set; }
	}

	[XmlRoot(ElementName="game")]
	public class GameEvents {
		[XmlElement(ElementName="inning")]
		public List<Inning> Inning { get; set; }
		[XmlElement(ElementName="atBat")]
		public AtBat AtBat { get; set; }
		[XmlElement(ElementName="deck")]
		public Deck Deck { get; set; }
		[XmlElement(ElementName="hole")]
		public Hole Hole { get; set; }
	}

  
}