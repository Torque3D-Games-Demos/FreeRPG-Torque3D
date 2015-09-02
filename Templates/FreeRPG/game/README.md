### FreeRPG Project ###

The FreeRPG Project is an idea to create a totally open-source and free RPG from assets to game engine, FreeRPG uses the Torque3D MIT engine. The project has only just started and it is literally just stock Torque3D at the moment with some open-source assets available but the plan is to create a base RPG which users can then either "mod" or use to create their own FreeRPG. For more info check out the links below:

[FreeRPG Project Website](http://freerpgproject.wordpress.com)

[FreeRPG Project Trello](https://trello.com/b/2BrEPQ2C/freerpg-project-planning)

[FreeRPG-Torque3D Repo](https://gitlab.com/FreeRPG/FreeRPG-Torque3D)

[FreeRPG Release Repo](https://gitlab.com/FreeRPG/FreeRPG)

[FreeRPG Wiki](http://freerpgproject.wikidot.com/)

#### Notes ####

* I advise using SSH to clone the repo as opposed to HTTPS due to its size, this requires having an SSH key generated on your system, please see [this link for more information.](https://help.github.com/articles/generating-ssh-keys/)
* When compiling the engine from source it is possible to use the Project Manager/CMAKE to generate your FreeRPG project if you wish, the instructions listed at the [FreeRPG-Torque3D](https://gitlab.com/FreeRPG/FreeRPG-Torque3D#compile-from-source) repo are only a very basic set, more information can be found at the [Torque3D Wiki](http://torque3d.wikidot.com/).
* I will provide only 32-bit binaries in the [FreeRPG](https://gitlab.com/FreeRPG/FreeRPG) release repo for windows until the linux/64-bit support is more stable but you are welcome to try them for yourself using the [FreeRPG-Torque3D](https://gitlab.com/FreeRPG/FreeRPG-Torque3D) engine repo and the instructions available at the [Torque3D Wiki](http://torque3d.wikidot.com/).

#### How do I get set up? ####

If you simply want to play FreeRPG then all you need to do is clone this repo with the command below:

```git clone git@gitlab.com:FreeRPG/FreeRPG.git```

You should now have a ```FreeRPG.exe``` file in your newly cloned repo folder which you can use to run the FreeRPG Project.

If you would like to compile the engine/game from source to either contribute or to create your own RPG then head over to the [FreeRPG-Torque3D](https://gitlab.com/FreeRPG/FreeRPG-Torque3D) repo and follow the instructions provided.

#### Contribution ####
Please note that FreeRPG is still in the very early stages of development, DO NOT expect much, nothing is finished (or started in most cases) and if you would like to help contribute to the FreeRPG Project then please use the [Contact Form](http://freerpgproject.wordpress.com/contact) available at the website. If you prefer to get your hands dirty then fork the [FreeRPG-Torque3D](https://gitlab.com/FreeRPG/FreeRPG-Torque3D) repo and create your own branch for your development work, then make a pull request when ready.

### Torque 3D ###

MIT Licensed Open Source version of [Torque 3D](http://torque3d.org) from [GarageGames](http://www.garagegames.com)

#### More Information ####

* [Homepage](http://torque3d.org)
* [Torque 3D wiki](http://wiki.torque3d.org)
* [Community forum](http://forums.torque3d.org)
* [GarageGames forum](http://www.garagegames.com/community/forums)
* [GarageGames professional services](http://services.garagegames.com/)

#### Pre-compiled Version ####

In addition to GitHub we also have a couple of pre-packaged files for you to download if you would prefer to not compile the code yourself.
They are available from the [downloads](http://wiki.torque3d.org/main:downloads) page on the wiki.

#### Related repositories ####

* [Torque 3D main repository](https://github.com/GarageGames/Torque3D)
* [Project Manager repository](https://github.com/GarageGames/Torque3D-ProjectManager)
* [Offline documentation repository](https://github.com/GarageGames/Torque3D-Documentation)

#### License ####

    Copyright (c) 2012 GarageGames, LLC

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to
    deal in the Software without restriction, including without limitation the
    rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
    sell copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:
    
    The above copyright notice and this permission notice shall be included in
    all copies or substantial portions of the Software.
    
    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
    FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
    IN THE SOFTWARE.