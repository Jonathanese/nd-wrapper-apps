# Jonathanese's NetDaemon Wrapper

This is an expansion/wrapper to [NetDaemon](https://github.com/net-daemon/netdaemon)

While this is just a personal project, the goal is to create an additional abstraction layer on top of NetDaemon to help organize some of the more cryptic or manual elements of navigating Home Assistant's API.

Planned features will include:
## Lighting
### Multi-layer colors and blending
This wrapper handles lighting through Managed Light (MLight) objects which can store and blend several layers of color. What might layering be good for?
Let's say your "base white" that you use on a day-to-day basis changes from cool white to warm white depending on the time of day. Now let's say you want to apply a forest theme to the room's lighting. On top of that, you want a light to turn red if you left your front door unlocked.
- When you close the door, you want that light to return to its theme color.
- When you turn off the theme, you want to return to your base color.
- If you change the theme, you don't want it to override your door-unlocked indicator.
- Nor do you want any updates to your base color to override your currently-selected theme.

This wrapper stores each of these elements as separate layers and shows the values depending on their priority. Similarly, each of these layers can be blended together for more complex lighting heirarchies.

### HDR Color Processing
Commercial smart lighting generally operates in a Hue/Saturation/Brightness color space, while custom devices often use 8-bit-per-channel RGB and 8-bit brightness.
This wrapper unifies RGB8+8 to RGB16
