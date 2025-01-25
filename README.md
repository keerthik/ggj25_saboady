# Global Game Jam 2025
Welcome to the source files for our team's project.

## Tech
- Unity: v6000.0.35f1

### Contribution protocol

This is a general guide, we'll make many exceptions for speed this weekend. If any of the following don't make sense to you but think it might be relevant to what you're doing, feel free to ask Keerthik!

- Branch etiquette is important to minimize time spent in tracking down/reverting changes
    - A programmer will maintain the `main` branch
    - Feel free to create any number of local branches on your machine to work in
    - Work primarily in a branch only you work on!
    - Submit a pull request to the `main` branch (you can do this informally by just telling a programmer)
- Unity prefab isolation is important to minimize work lost/need to be redone from conflicts
    - Collisions from multiple contributors can be hard to resolve on Unity asset files (scenes, prefabs, inspector values) without redoing/losing work
    - Isolate your work to a single Unity "prefab" if you are touching any scene assets/inspector values
    - Commit and push your work on one prefab at a time before you push any changes to a different one
- It's probably best to let others know which scene/prefab/component you're currently working on and when you're done, so others know not to mess with it until they've received your push. I suggest a simple message in discord with a standardized notation so anyone can look without disturbing others in the middle of their work
    - when you start work, post "branch: `level-blockout`, scene: `level1`, prefab: `cultquestitem`"
    - when you have finished making all of your commits to prefab, and moving on to another one, you can delete that message and post a new one with what you will be working on
    - it's not a big deal if you skip this if you think no one else will be modifying your prefab
    - This is far less relevant when editing C#, json, or text code directly.

## Theme/diversifiers

Theme: ""Bubble""
