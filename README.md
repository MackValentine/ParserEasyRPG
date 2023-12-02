# ParserEasyRPG

<h2 align="left">Launcher</h2>

Launcher allow you to extract all data each time you run the game

( extract.bat is optional if you use the Launcher )

<h2 align="left">Parser</h2>


<h2 align="left">Data extracted : </h2>

<h4 align="left">Actors : </h4>
- attribute rate
- classID
- exp Accumulation
- exp Basic
- exp Extra
- faceset
- nickname
- state rate
- critical hit
- critical rate

<h4 align="left">Attributes : </h4>
- attribute rate

<h4 align="left">Enemies : </h4>
- agi
- animation id
- atk
- attribute rate
- battler name
- def
- exp
- gold
- loot id
- loot rate
- max HP
- max MP
- mind
- state rate
- critical hit
- critical rate
<h6 align="left">Enemy Actions : </h6>
For each a enemy a file named enemy_XXX_actions.txt will be created.
It contains : condition priotity switch_id parameter1 parameter2 switchOn switchOff kind basic skill_id enemy_id


<h4 align="left">Items : </h4>
- actor equipable
- agi up
- animation id
- atk up
- attribute rate
- class equipable
- consumption limit
- cursed
- def up
- description
- entire party
- equipment agi
- equipment atk
- equipment def
- equipment mag
- hp recovery
- hp recover rate
- hp up
- ko only
- mag up
- mp up
- price
- scope
- skill id
- sp recover
- sp recover rate
- state resist
- state set
- switch id
- type
- usable in battle
- weapon animation id
- attack all
- dual attack
- half sp cost
- ignore evasion
- no terrain damage
- preemptive
- raise evasion
- prevent critical hit
- two handed

<h4 align="left">Skills : </h4>
- animation id
- attribute effect
- cost
- cost rate
- description
- increase HP / renamed in affect HP
- increase MP / renamed in affect MP
- inflict state
- magical rate
- physical rate
- power
- scope
- states
- types
- absorb_damage
- affect Agi
- affect Atk
- affect Def
- affect Mnd
- success Rate
- ignore defense


<h4 align="left">States : </h4>
- rate
- restricted magical
- restricted physical
- types

<h4 align="left">Terrains : </h4>
- battleback

<h4 align="left">Troops : </h4>
- enemy id
- enemy invisible
- enemy x
- enemy y
- name

<h2 align="left">Extract.bat</h2>

You can remove the -subfolder to create all .txt files in the Text/ folder.


<h2 align="left">Parser's Installation</h2>

1- Copy Parser.exe in the Text folder, or Main folder of your project

2- Copy extract.bat in the Main folder of your project

3- Copy lcf2xml.exe in the Main folder of your project ( https://easyrpg.org/tools/downloads/ )

4- Run extract.bat 

<h2 align="left">Launcher's Installation</h2>

1- Rename your RPG_RT.exe in Game.exe

2- Copy RPG_RT.exe in the Main folder of your project

3- Add a file splashscreen.png (800/450) in the Main folder of your project ( optionnal )

4- Run RPG_RT.exe 
