# Life-Cycle-Asset

This pattern builded on these two scripts, these are Sequence Manager and UI Manager. These two scripts running independence each other. They use singneleton so you can access any where easily. 

</br><p align="center"><img src="https://github.com/Deaglis1197/Life-Cycle-Asset/blob/main/diagram.png" width="256"/></p>

##Sequence Manager
<ul>
<li>Manage all game state in this script.</li>
<li>Managing game states with State Machine.</li>
<li>Only one game state running and change this state when you want easily.</li>
<li>All game state registered on this script with Unity Serializefield.</li>
<li>All game state has OnStart and OnExit.</li>
</ul>

Eventually all game circle living on this script. For example, when the game complete, InGame state switch to GameOver state so game is over.

##UI Manager
<ul>
<li>Manage all UI Canvas in this script.</li>
<li>All UI Canvas registered on this script with Unity Serializefield.</li>
<li>Enable and Disable all UI Canvas on this script.</li>
<li>Enable two or more UI Canvas at the same time is allowed.</li>
<li>Access all canvas through this script.</li>
<li>All Canvases has OnEnabled and OnDisabled.</li>
<ul>

UI Manager can work with together Sequence Manager, For example when player wants to open pause menu, game state change to pause, at the same time, InGame Canvas Disable and after that Pause Canvas Enable.
