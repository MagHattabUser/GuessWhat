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
            XDoc.Load("player.xml");
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
                    XmlNode attr = xnode.Attributes.GetNamedItem("username");
                    player.SetUserName(attr.Value);

                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "login")
                        {
                            player.SetLogin(childnode.InnerText);
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
            XmlAttribute userNameAttr = XDoc.CreateAttribute("username");

            // создаем элементы
            XmlElement loginElem = XDoc.CreateElement("login");
            XmlElement passwordElem = XDoc.CreateElement("password");
            XmlElement musicScoreElem = XDoc.CreateElement("musicscore");
            XmlElement filmScoreElem = XDoc.CreateElement("filmscore");
            XmlElement wordScoreElem = XDoc.CreateElement("wordscore");

            // создаем текстовые значения для элементов и атрибута
            XmlText userNameText = XDoc.CreateTextNode(player.GetUserName());
            XmlText loginText = XDoc.CreateTextNode(player.GetLogin());
            XmlText passwordText = XDoc.CreateTextNode(player.GetPassword());
            XmlText musicScoreText = XDoc.CreateTextNode(player.GetMusicScore().ToString());
            XmlText filmScoreText = XDoc.CreateTextNode(player.GetFilmScore().ToString());
            XmlText wordScoreText = XDoc.CreateTextNode(player.GetWordScore().ToString());

            //добавляем узлы
            userNameAttr.AppendChild(userNameText);
            loginElem.AppendChild(loginText);
            passwordElem.AppendChild(passwordText);
            musicScoreElem.AppendChild(musicScoreText);
            filmScoreElem.AppendChild(filmScoreText);
            wordScoreElem.AppendChild(wordScoreText);

            // добавляем атрибут
            playerElem.Attributes.Append(userNameAttr);
            // добавляем элементы
            playerElem.AppendChild(loginElem);
            playerElem.AppendChild(passwordElem);
            playerElem.AppendChild(musicScoreElem);
            playerElem.AppendChild(filmScoreElem);
            playerElem.AppendChild(wordScoreElem);
            
            // добавляем в корневой элемент новый элемент person
            XRoot.AppendChild(playerElem);
            // сохраняем изменения xml-документа в файл
            XDoc.Save("player.xml");
        }
    }
}
