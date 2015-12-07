using System;
using System.Linq;
using TheSlum.Characters;
using TheSlum.Items;

namespace TheSlum.GameEngine
{
    public class AdvancedEngine : Engine
    {
        protected override void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "create":
                    CreateCharacter(inputParams);
                    break;
                case "add":
                    AddItemToCharacter(inputParams);
                    break;
                default:
                    base.ExecuteCommand(inputParams);
                    break;
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            string characterType = inputParams[1];
            string id = inputParams[2];
            int x = int.Parse(inputParams[3]);
            int y = int.Parse(inputParams[4]);
            string teamType = inputParams[5];
            Team team = (Team)Enum.Parse(typeof(Team), teamType);

            Character character = CharacterFactory.Create(characterType, team, id, x, y);
            characterList.Add(character);
        }

        protected void AddItemToCharacter(string[] inputParams)
        {
            string characterId = inputParams[1];
            Character character = characterList
                .First(x => x.Id == characterId);

            Item item = ItemFactory.Create(inputParams[2], inputParams[3]);

            character.AddToInventory(item);
        }
    }
}