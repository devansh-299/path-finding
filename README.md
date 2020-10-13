# Path Finding

## NavMesh - Unity

NavMesh is a class that can be used to do spatial queries, like pathfinding (_major focus for this repository_), walkability tests etc. 
It is implemented inside `UnityEngine.AIModule` package and it internally uses **A\* Algorithm**.
<br />
For more information refer the official documentations:
* Building a NavMesh - [link](https://docs.unity3d.com/Manual/nav-BuildingNavMesh.html)
* Internal working of NavMesh - [link](https://docs.unity3d.com/Manual/nav-InnerWorkings.html)

## Project Details
This repository contains my experiments and findings about the Unity's NavMesh component. I will be using different branches to maintain different sets of
games scenes and NavMesh's implementation over them. At the moment, I have worked upon two sets of game scences:
* **master branch**
  <br />
  This branch contains the most basic implementation of NavMesh in unity. The game scene contains a simple 3-D ground with few obstacles in between.
  <br />
  <div align="center">
    <img src="https://user-images.githubusercontent.com/46667021/95844714-d8cbeb00-0d66-11eb-9cad-502c15810752.jpg" width="250" height="450" />
    <br />
    <i>Game running on an Android device</i>
  </div>
  
* **slope-maze branch**
  <br />
  This branch contains a relatively complex implementation of Unity's NavMesh component. The game scene involves a custom slope (_designed using Blender_) to test the mesh
  in case of slopes.
  <br />
  <div align="center">
    <img src="https://user-images.githubusercontent.com/46667021/95842883-b638d280-0d64-11eb-8061-4fd08fd84078.jpg" width="500" height="300" />
    <br />
    <i>Game Scene with mesh</i>
  </div>
  
  
  
  
