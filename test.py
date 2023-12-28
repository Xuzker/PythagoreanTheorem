from yandex_tracker_client import TrackerClient
client = TrackerClient(token='y0_AgAAAAAZDvXWAAsP2wAAAAD2NHAkV775oI5KSLKqARWteiTqurDWYD8', cloud_org_id='bpfndimlbi46t0cd4jo0')
client.issues.create(
    queue="TEAMCITYBUILDFA",
    summary="",
    assignee="vyacheslavgvozdikov",
    description='opisanie'
)
