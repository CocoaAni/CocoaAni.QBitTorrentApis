namespace CocoaAni.QBitTorrentApis.Enums;

public enum TrackerStatus
{
    TrackerIsDisabled = 0, //(used for DHT, PeX, and LSD)
    TrackerHasNotBeenContactedYet = 1,
    TrackerHasBeenContactedAndIsWorking = 2,
    TrackerIsUpdating = 3,
    TrackerHasBeenContactedButItIsNotWorking = 4 //(or doesn't send proper replies)
}