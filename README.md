<p align="center">
  <img src="https://github.com/InfGame/corvus/blob/master/Assets/Logo/Logo_Name_552px.png?raw=true" alt="Corvus Logo"/>
</p>

# Description

Corvus will be an open-source and free All-In-One suite for everything around the Event stage. You should be able to use it in various settings from small Clubs to Theater stages all the way to big Festival Stage-rigs and even in the Virtual World.

# Roadmap

Since this project is new and I am the only one developing this Project, this Roadmap and this ReadMe in the entirety will be updated frequently.

The Time for completing each goal on the Roadmap is not specified since I am the only one developing this Project I am making this in my own free time.

### First Steps

#### Fixture Editor
First on the Agenda is building a Fixture editor that allows you to Create and Edit [GDTF files](https://github.com/mvrdevelopment/spec) and Export it as such as well

#### Stage Editor / Rig Creator
Next I want you to be able to easily Create or Edit a Stage / Rig from scratch or either Imported through an [MVR file](https://github.com/mvrdevelopment/spec) and Export it as well

### Becoming useful

#### Stage-lighting workflow
After I have made a comprehensive Fixture and Stage Editor I want users to be able to send and/or receive DMX signals through Artnet, E1.31, OSC, as well as OpenDMX and preview them in the 3D view.

With This I want to implement a Control Surface that you can use on a Touch screen for Live control, a MIDI and OSC Implementation will also allow you to control Corvus using External MIDI controllers and other Hardware.

#### Timeline Editor and Key-Frame animations for Pre-programmed Events
A full Timeline Editor should allow you to Pre-programm your entire Event or just parts of it that you can then trigger Live.

#### MIDIDMX and Grid-Node for Virtual Stage Rigs
Corvus should give you the ability to drive [micca's MIDIDMX](https://github.com/micksam7/VRC-MIDIDMX) straight from itself as well as Export a Grid-node through a spout stream based on [HappyRobot's HNode](https://github.com/Happyrobot33/HNode).

#### Visuals and Video
Corvus should get its own Video-Mapper and built-in compositor as well that, combined with the Live Controls or Timeline should help users create comprehensive Visuals for their Events in the same project as the Lighting.

These visuals can be then exported through a spout stream with the Grid-node together if needed.

### Extras

#### Movable Trusses and XYZ Mode
Corvus should support Movable trusses, either through winches or free floating an a virtual space that you can manipulate by just moving the truss through 3D space in the 3D View and using key-frame animations and the timeline Editor.

Fixtures should be able to to focus on a point in 3D space as well by just defining / moving a point in said space and letting Corvus do the necessary tilt/pan calculations for the fixture to point at it.

#### Drone shows
With XYZ Moe an Movable Trusses I will also have a solid base to support Drone-shows inside Corvus as well.
