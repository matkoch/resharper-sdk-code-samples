package com.jetbrains.rider.plugins.samples.actions

import com.jetbrains.rider.actions.base.RiderAnAction
import icons.ReSharperIcons

class SampleAction : RiderAnAction(
    backendActionId = "SampleAction",
    text = "Sample Action",
    description = null,
    // Icon must also be changed in backend code
    icon = ReSharperIcons.FeaturesInternal.QuickStartToolWindow
)