using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;   

namespace GuessWhat
{
    internal class XML
    {
        private XmlDocument XDoc = new XmlDocument();
        private XmlElement XRoot;

        public XML()
        {
            XDoc.Load("players.xml");
            XRoot = XDoc.DocumentElement;
        }

        public List<Player> GetAllPlayers()
        {
            var players = new List<Player>();

            if (XRoot != null)
            {
                foreach (XmlElement xnode in XRoot)
                {
                    Player player = new Player();
                    XmlNode attr = xnode.Attributes.GetNamedItem("login");
                    player.SetLogin(attr.Value);

                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "username")
                        {
                            player.SetUserName(childnode.InnerText);
                        }

                        if (childnode.Name == "password")
                        {
                            player.SetPassword(childnode.InnerText);
                        }

                        if(childnode.Name == "musicscore")
                        {
                            player.SetMusicScore(int.Parse(childnode.InnerText));
                        }

                        if (childnode.Name == "filmscore")
                        {
                            player.SetFilmScore(int.Parse(childnode.InnerText));
                        }

                        if (childnode.Name == "wordscore")
                        {
                            player.SetWordScore(int.Parse(childnode.InnerText));
                        }
                    }
                    players.Add(player);
                }
            }
            return players;
        }

        public void AddNewPlayer(Player player)
        {
            // создаем новый элемент
            XmlElement playerElem = XDoc.CreateElement("player");

            // создаем атрибут
            XmlAttribute loginAttr = XDoc.CreateAttribute("login");

            // создаем элементы
            XmlElement usernameElem = XDoc.CreateElement("username");
            XmlElement passwordElem = XDoc.CreateElement("password");
            XmlElement musicScoreElem = XDoc.CreateElement("musicscore");
            XmlElement filmScoreElem = XDoc.CreateElement("filmscore");
            XmlElement wordScoreElem = XDoc.CreateElement("wordscore");

            // создаем текстовые значения для элементов и атрибута
            XmlText usernameText = XDoc.CreateTextNode(player.GetUserName());
            XmlText loginText = XDoc.CreateTextNode(player.GetLogin());
            XmlText passwordText = XDoc.CreateTextNode(player.GetPassword());
            XmlText musicScoreText = XDoc.CreateTextNode(player.GetMusicScore().ToString());
            XmlText filmScoreText = XDoc.CreateTextNode(player.GetFilmScore().ToString());
            XmlText wordScoreText = XDoc.CreateTextNode(player.GetWordScore().ToString());

            //добавляем узлы
            loginAttr.AppendChild(loginText);
            usernameElem.AppendChild(usernameText);
            passwordElem.AppendChild(passwordText);
            musicScoreElem.AppendChild(musicScoreText);
            filmScoreElem.AppendChild(filmScoreText);
            wordScoreElem.AppendChild(wordScoreText);

            // добавляем атрибут
            playerElem.Attributes.Append(loginAttr);
            // добавляем элементы
            playerElem.AppendChild(usernameElem);
            playerElem.AppendChild(passwordElem);
            playerElem.AppendChild(musicScoreElem);
            playerElem.AppendChild(filmScoreElem);
            playerElem.AppendChild(wordScoreElem);
            
            // добавляем в корневой элемент новый элемент person
            XRoot.AppendChild(playerElem);
            // сохраняем изменения xml-документа в файл
            XDoc.Save("players.xml");
        }

        public bool IsLoginContains(string login)
        {
            foreach (XmlElement xnode in XRoot)
            {
                XmlNode attr = xnode.Attributes.GetNamedItem("login");
                if (attr.Value == login)
                {
                    return true;
                }
            }
            return false;
        }

        public Player GetPlayer(string login)
        {
            Player player = new Player();
            foreach (XmlElement xnode in XRoot)
            {
                XmlNode attr = xnode.Attributes.GetNamedItem("login");
                if (attr.Value == login)
                {
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "username")
                        {
                            player.SetUserName(childnode.InnerText);
                        }

                        if (childnode.Name == "password")
                        {
                            player.SetPassword(childnode.InnerText);
                        }

                        if (childnode.Name == "musicscore")
                        {
                            player.SetMusicScore(int.Parse(childnode.InnerText));
                        }

                        if (childnode.Name == "filmscore")
                        {
                            player.SetFilmScore(int.Parse(childnode.InnerText));
                        }

                        if (childnode.Name == "wordscore")
                        {
                            player.SetWordScore(int.Parse(childnode.InnerText));
                        }
                    }
                    break;
                }
            }
            return player;
        }

        public string GetPassword(string login)
        {
            foreach (XmlElement xnode in XRoot)
            {
                XmlNode attr = xnode.Attributes.GetNamedItem("login");
                if (attr.Value == login)
                {
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "password")
                        {
                            return childnode.InnerText;
                        }
                    }
                }                
            }
            return null;
        }
    }
}
