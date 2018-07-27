import * as React from 'react';
import { TopQuestions } from './TopQuestions';
import { RouteComponentProps } from 'react-router';

export class Home extends React.Component<RouteComponentProps<{}>, {}> {
    public render() {
        return <div>
            <TopQuestions />
        </div>;
    }
}
