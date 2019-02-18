# Project CodeStar

Hey guys! First Unity repo. Let me know what would be helpful here, shooting blind out here.

Did I include too many assets? too few? :shrug:

## Overview

Most of the logic lives in scripts rather than in the game lifecylce. Not sure it that's ideal or not, but it's almost exclusively based off of this [Demo by Breckey](https://www.youtube.com/watch?v=HvMrOoUeqO0).

There are only a few scripts, but it immediately becomes overwhelmingly confusing.

I'll try and do a clarity pass at some point soon, but I want to get it working a little more first.

## Basics

* Manager
  * In charge of requesting new prompts, tracking old ones, etc
* Display
  * This controls the Text to display (translation to Unity TextMeshPro component)
* Spawner
  * Does very little, just creates the new Instance
* Generator
  * returns randomized text
  * I'd like to build this into the adventure generator, so you will have a sequence of related tasks that can be interrupted
* Input
  * Just that, it listens to the keys typed per frame


