// generated file
import {GetJson, PostJson} from '../Common/Api/Fetch.ts'
import {IApplicationContext} from '../Common/Contexts.tsx'

export class Test {
    PostSomething(input: IDummyInput, applicationContext: IApplicationContext): Promise<IErrorResponse> {
        return PostJson(input, "test", "postsomething", applicationContext);
    }

    GetSomething(applicationContext: IApplicationContext): Promise<IDummyResult> {
        return GetJson("test", "getsomething", applicationContext);
    }

    GetError(applicationContext: IApplicationContext): Promise<IErrorResponse> {
        return GetJson("test", "geterror", applicationContext);
    }

}

export class Village {
    GetVillage(applicationContext: IApplicationContext): Promise<IVillageDto> {
        return GetJson("village", "getvillage", applicationContext);
    }

    HarvestLog(input: IHarvestLogInput, applicationContext: IApplicationContext): Promise<IErrorResponse> {
        return PostJson(input, "village", "harvestlog", applicationContext);
    }

    HarvestStone(input: IHarvestStoneInput, applicationContext: IApplicationContext): Promise<IErrorResponse> {
        return PostJson(input, "village", "harveststone", applicationContext);
    }

    HarvestCoal(input: IHarvestCoalInput, applicationContext: IApplicationContext): Promise<IErrorResponse> {
        return PostJson(input, "village", "harvestcoal", applicationContext);
    }

}

export class ApiContext {
    Test: Test;
    Village: Village;

    constructor() {
        this.Test = new Test();
        this.Village = new Village();
    }
}

export const Api = new ApiContext();

export interface IDummyInput {
    someValue: string;
}

export interface IErrorResponse {
    message: string;
}

export interface IDummyResult {
    someValue: string;
}

export interface ILumberjackHouseDto {
    houseName: string;
    houseNumber: number;
    resourceName: string;
    logCount: number;
}

export interface IStoneMineDto {
    houseName: string;
    houseNumber: number;
    resourceName: string;
    stoneCount: number;
}

export interface ICoalMineDto {
    houseName: string;
    houseNumber: number;
    resourceName: string;
    coalCount: number;
}

export interface IVillageDto {
    lumberjack: ILumberjackHouseDto;
    stoneMine: IStoneMineDto;
    coalMine: ICoalMineDto;
}

export interface IHarvestLogInput {
}

export interface IHarvestStoneInput {
}

export interface IHarvestCoalInput {
}

