#!/usr/bin/env python3
#
# Copyright (c) 2018 LG Electronics, Inc.
#
# This software contains code licensed as described in LICENSE.
#

import os
import lgsvl
import random
import time

sim = lgsvl.Simulator(os.environ.get("SIMULATOR_HOST", "127.0.0.1"), 8181)
if sim.current_scene == "SanFrancisco":
  sim.reset()
else:
  sim.load("SanFrancisco")

spawns = sim.get_spawn()

state = lgsvl.AgentState()
state.transform = spawns[1]
a = sim.add_agent("XE_Rigged-apollo", lgsvl.AgentType.EGO, state)

print(sim.weather)

input("enter to set rain to 80%")

sim.weather = lgsvl.WeatherState(rain=0.8, fog=0, wetness=0)
print(sim.weather)

sim.run(5)

input("enter to set fog to 50%")

sim.weather = lgsvl.WeatherState(rain=0, fog=0.5, wetness=0)
print(sim.weather)

sim.run(5)

input("enter to set wetness to 50%")

sim.weather = lgsvl.WeatherState(rain=0, fog=0, wetness=0.5)
print(sim.weather)

sim.run(5)

input("enter to reset to 0")

sim.weather = lgsvl.WeatherState(rain=0, fog=0, wetness=0)
print(sim.weather)

sim.run(5)
