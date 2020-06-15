# Astar
Ai 2020 pathfinding


The whole project contains the following files.

- Materials
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

This folder contains unity materials for the objects have basic properties like colour and shaders.

- Scenes
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

This folder contains diffrents scece where i impliment the diffrent AI.
    
+ Patrol

Contains the navmesh for the scene followplayer map.
    
+ Astar pathfinding

This scene contains the Astar implementation withing a simple map.

+ Followplayer

This scene contains An ai that follows the player. This is done by baking a navigation area on the objects/map.

+ Learning

This scene contains an ai that keep a particular distance with the player. if a player goes too far Ai start following the player and if the player comes too close Ai will go in the opposite direction.

+ Patrol

This scene contains the implementation of simple patrol ai. Where the object run a set point on the map and stay there for 2 sec then move to the next point on the map.

- Scritps 
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

This folder contains 4 diffrent scripts 

+ Enemy

    This script connected with an Enemy object in learning scene. contains information about the following player also have some personalization options such as enemy speed, stop distance retreat distance.

+ Followplayer

    This script is attached with Ai_playerfollow object. Also, have the option to change the target to follow.

+ PatrolAi

    This script is attached with the Ai_player object in Patrol scene. Also, have the option to change the location and size of the patrol points on the map.

+ Playermove
    
    Simple player move script attached with the player in follow the player scene and also in the Learning scene. It has a basic script to control the object with simple keyboard inputs.


- Scripts 2 
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

This folder contains 6 different scripts that were used for implementing the A* algorithm in the Astar pathfinding scene.

+ 1 Grid

    This script is used to make gizmos to visualize the grid on the area you want to cover up. and other information like unwalkable mask. where we want to put obstacles on the area. have public variable s like grid world size and node size. 

+ 2 heap

    This script is a c# script have not attached with any object rather it used in the pathfinding script to find optimal path nodes on the gird.

+ 3 Node

    This script is used in the grid for establishing nodes and in the heap script to manipulate costs of the different nodes.
    
+ 4 pathfinding
    
    This script is used to establish the optimal path on the grid. with a different function to calculate the values of nodes.

+ 5 pathfindingRequestManager

    This script is used to manage multiple requests from a different node for establishing the optimal path.

+ 6 Units

    This script is attached to all the units that you want to make a path. also have gizmos to visualize the evaluation process on the map.

