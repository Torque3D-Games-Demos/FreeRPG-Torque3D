# FreeRPG Project contribution guidelines

So you want to help out by contributing to the repo? That's awesome!
We just ask that you'd give this document a quick read to get yourself familiar with the process.

* Do you want to request a feature?

* Create a pull-request to contribute your own code to the engine?

* Report an issue you've discovered?

## Report an issue

Before you report an issue please [search](https://gitlab.com/hreikin/FreeRPG-Project/issues) and quickly make sure someone else hasn't obviously reported it.
If you're not sure if it's the same issue, go ahead and comment on it!
Once you're certain you've found a new issue, hit the [big green button](https://gitlab.com/hreikin/FreeRPG-Project/issues/new?issue%5Bassignee_id%5D=&issue%5Bmilestone_id%5D=) and please include the following information:

 * Your platform and compiler
 * Steps to reproduce the issue, if _at all_ possible
 * If it's related to graphics, your GFX card and driver details.

## Create a pull-request

As the FreeRPG Project uses Torque3D we ask that potential contributors read the Torque3D [pull-request guidelines](http://torque3d.org/contribute/#pull-request-guide) before opening a PR.
We also follow the same [code style guidelines](https://github.com/GarageGames/Torque3D/wiki/Code-Style-Guidelines).
Here's a quick guide to the branches in this repo that you might think of targeting a PR at:

### The master branch

The repository's `master` branch is where we will make releases in the future.
It's supposed to be stable at all times - or as stable as we can make it - and only gets updated when a new version comes out.
Any pull-requests to the master branch will have to be rejected - sorry :(.

### The development branch

The `development` branch is where most development happens.
It is the target for the next version of the engine/game (the 6 in 3.6.1, for example).
This means we will add new features, and refactor code if it doesn't break existing games made with the engine _too_ much.
Most pull requests to `development` can be accepted if we like your code - unless they would potentially break games.

### TLDR

Don't make any PRs to `master`.
PR new features and large fixes/refactorings to `development`.