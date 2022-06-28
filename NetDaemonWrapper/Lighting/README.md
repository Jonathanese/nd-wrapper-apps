# Lighting

In Home Assistant, storing and recalling states like this can be a bit of a hassle to configure in YAML or even in Node-Red. This is where layering helps. The base color, theme color, and animation color can all be set independently and displayed based on priority, and even blended with one another for more complex hierarchies of animations. The list of current layers, in order of priority, are as follows:

0. **Base Color:** This is generally going to be your day-to-day white color, whether you prefer warm white, cool white, adjust to a circadian rhytm, or prefer a life in rose-tinted glasses.
1. **Theme Color:** This is the color set by a specific scene either set by home assistant or a scene set a JNDW theme.
2. **Custom Color:** Color set by specific request, overriding whatever the color is set by the theme.
3. **Anim Color:** Color set by an animation, usually an event-based color such as a notification, so it retains highest priority.

Each layer contains a FullColor which is in an RGB16 format, as well as a 8-bit alpha channel for blending. Current blend modes include Add, Multiply, and Alpha blending.

So blending can be gamma-correct, FullColor objects which represent "linear visual space" must be converted to PowerColor objects which represent "linear power/luminance space".

FullColor objects can be converted back to RGB8+8-bit brightness for display with Home Assistant.
