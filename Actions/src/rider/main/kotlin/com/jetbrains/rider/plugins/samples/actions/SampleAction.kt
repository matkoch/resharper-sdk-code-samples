package com.jetbrains.rider.plugins.samples.actions

import com.jetbrains.rider.actions.base.RiderAnAction
import icons.ReSharperIcons

class SampleAction : RiderAnAction(
    backendActionId = "SampleAction",
    text = "Sample Action",
    description = null,
    icon = ReSharperIcons.UnitTesting.TestFixtureToolWindow
)