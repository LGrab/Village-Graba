import {Button, Grid, GridColumn, GridRow} from "semantic-ui-react";
import InvertibleSegment from "../Common/InvertibleSegment.tsx";
import {Api, IDummyResult, IErrorResponse, IHarvestStoneInput, IVillageDto} from "../Api/Api.ts";
import {ApplicationContext, IApplicationContext} from "../Common/Contexts.tsx";
import {useContext, useState} from "react";

function VillagePage() {

    const applicationContext = useContext(ApplicationContext);

    const [serverValue, setServerValue] = useState<IDummyResult>();
    const [village, setVillage] = useState<IVillageDto>();


    function postSomething(value: string) {
        return Api.Test.PostSomething({someValue: value}, applicationContext);
    }

    function getSomething() {
        Api.Test.GetSomething(applicationContext)
            .then(value => setServerValue(value));
    }

    function triggerError() {
        Api.Test.GetError(applicationContext);
    }

    function getVillage() {
        Api.Village.GetVillage(applicationContext)
            .then(value => setVillage(value));
    }

    function harvestLog() {
        Api.Village.HarvestLog({}, applicationContext);
    }

    function harvestStone() {
        Api.Village.HarvestStone({}, applicationContext);
    }

    function harvestCoal() {
        Api.Village.HarvestCoal({}, applicationContext);
    }


    return (
        <InvertibleSegment>
            <Grid>

                <GridRow>
                    <GridColumn width={2}>
                        Some random buttons {serverValue?.someValue}
                    </GridColumn>
                    <GridColumn>
                        <Button color='orange' onClick={() => postSomething("test")}>Post</Button>
                    </GridColumn>
                    <GridColumn>
                        <Button color='orange' onClick={() => getSomething()}>Get</Button>
                    </GridColumn>
                    <GridColumn>
                        <Button color='red' onClick={() => triggerError()}>Error</Button>
                    </GridColumn>
                </GridRow>

                <GridRow>
                    <GridColumn width={2}>
                        Informace o vesnici získáš stistknutím modrého tlačítka.
                    </GridColumn>
                    <GridColumn width={2}>
                        <Button color='blue' onClick={() => getVillage()}>Informace o vesnici Vrkoslavice</Button>
                    </GridColumn>
                </GridRow>

                <GridRow>
                    <GridColumn width={2}>
                        Názvy domů a jejich číslá popisná jsou:
                    </GridColumn>

                    <GridColumn>
                        {village &&
                            <InvertibleSegment> {village.lumberjack.houseName} <br/> {village.lumberjack.houseNumber}
                            </InvertibleSegment>
                        }
                    </GridColumn>
                    <GridColumn>
                        {village &&
                            <InvertibleSegment> {village.stoneMine.houseName} <br/> {village.stoneMine.houseNumber}
                            </InvertibleSegment>}
                    </GridColumn>
                    <GridColumn width={2}>
                        {village &&
                            <InvertibleSegment> {village.coalMine.houseName} <br/> {village.coalMine.houseNumber}
                            </InvertibleSegment>}
                    </GridColumn>

                </GridRow>

                <GridRow>
                    <GridColumn width={2}>
                        Pokud chceš těžit surovinu, stiskni ikonku.
                    </GridColumn>
                    <GridColumn>
                        <Button color='green' onClick={() => harvestLog()}>Uřízni kládu</Button>
                    </GridColumn>
                    <GridColumn>
                        <Button color='green' onClick={() => harvestStone()}>Vykopej kámen</Button>
                    </GridColumn>
                    <GridColumn>
                        <Button color='green' onClick={() => harvestCoal()}>Natěž uhlí</Button>
                    </GridColumn>
                </GridRow>

                <GridRow>
                    <GridColumn width={2}>
                        Informace o množství surovin získáš kliknutím na modré tlačítko
                    </GridColumn>

                    <GridColumn>
                        {village &&
                            <InvertibleSegment> {village.lumberjack.resourceName} <br/> {village.lumberjack.logCount}
                            </InvertibleSegment>}
                    </GridColumn>
                    <GridColumn>
                        {village &&
                            <InvertibleSegment> {village.stoneMine.resourceName} <br/> {village.stoneMine.stoneCount}
                            </InvertibleSegment>}
                    </GridColumn>
                    <GridColumn>
                        {village &&
                            <InvertibleSegment> {village.coalMine.resourceName} <br/> {village.coalMine.coalCount}
                            </InvertibleSegment>}
                    </GridColumn>
                    <GridColumn>
                        <Button color='blue' onClick={() => getVillage()}>Aktuální množství surovin</Button>
                    </GridColumn>
                </GridRow>

            </Grid>
        </InvertibleSegment>
    )
}

export default VillagePage
