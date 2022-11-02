# Engines_InClass

The sum of every digit in my student number is 37 [1 + 7 + 8 + 4 + 8 + 9 = PRIME]

Assets folder contains:

Code [Scripts]

Game Scene [Scenes]

GameObject Prefabs [Prefabs]

Command is used for Donkey Kong to throw barrels. If the player uses the power-up, it will undo the last barrel throw. 
DKBarrelThrow is a child of the ICommand interface, and the Invoker class manages DKBarrelThrow commands. It stores them in a stack after executing so that they can be undone in a last in/first out manner. 

BUILD FILES ARE LOCATED IN THE EXECUTABLE FOLDER
